using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class Administrador : Form
    {
        private Controlador_Incidencias controlador_Incidencias;
        private Controlador_Perfiles controlador_Perfiles;
        private List<Incidencias> lista_Incidencias;
        public Incidencias incidencias;
        private int modoAdmin = 0;
        public Administrador()
        {
            controlador_Incidencias = new Controlador_Incidencias();
            controlador_Perfiles = new Controlador_Perfiles();
            incidencias = new Incidencias();

            InitializeComponent();
            cargarComboBoxs();
            cargarListaIncidencias();
        }

        private void cargarComboBoxs()
        {
            cbbTipo.Items.Clear();
            cbbSubtipo.Items.Clear();
            cbbSubtipo.Enabled = false;
            cbbEstado.Items.Clear();
            Array tipos = Enum.GetValues(typeof(Tipo));
            foreach (Tipo tipo in tipos)
            {
                this.cbbTipo.Items.Add(Convert.ToString(tipo));
            }
            Array subtipos = Enum.GetValues(typeof(Subtipo));
            foreach (Subtipo subtipo in subtipos)
            {
                this.cbbSubtipo.Items.Add(Convert.ToString(subtipo));
            }
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (Estado estado in estados)
            {
                this.cbbEstado.Items.Add(Convert.ToString(estado));
            }
        }

        private async void cargarListaIncidencias()
        {
            lista_Incidencias = await
                controlador_Incidencias.GetAllIncidencias();
            cargarDgv(lista_Incidencias);
        }

        private void cbbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTipo.SelectedItem.Equals(Convert.ToString(Tipo.Equipos)))
            {
                cbbSubtipo.Enabled = true;
            }
            else
            {
                cbbSubtipo.Enabled = false;
                cbbSubtipo.Text = string.Empty;
            }
        }
        private void cargarDgv(List<Incidencias> lista)
        {
            if (lista != null)
            {
                dvgIncidencias.Rows.Clear();
                foreach (var incidencia in lista)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dvgIncidencias);
                    row.Cells[0].Value = incidencia.num;
                    row.Cells[1].Value = incidencia.personal1.nombre;
                    row.Cells[2].Value = incidencia.personal2.nombre;
                    row.Cells[3].Value = incidencia.tipoIncidencia;
                    row.Cells[4].Value = incidencia.tipoEstado;
                    row.Cells[5].Value = incidencia.fecha_creacion;
                    row.Cells[6].Value = incidencia.fecha_cierre;

                    dvgIncidencias.Rows.Add(row);

                }
            }
            else
            {
                MessageBox.Show("No se pudo obtener la petición. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
        private async void filtrado()
        {
            List<Incidencias> lista = null;

            lista = await controlador_Incidencias.GetAllIncidenciasPorFiltro(cbbTipo.Text, cbbEstado.Text, cbbSubtipo.Text);

            if (lista == null)
            {
                MessageBox.Show("No existe ninguna incidencia por los parametros recibidos. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cargarDgv(lista);
            }
        }

        private void cambioFiltrado(object sender, EventArgs e)
        {
            filtrado();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            cargarListaIncidencias();
            cbbEstado.Text = string.Empty;
            cbbSubtipo.Text = string.Empty;
            cbbTipo.Text = string.Empty;
            cargarListaIncidencias();
            modoAdmin--;
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            Incidencias incid = new Incidencias();
            if (dvgIncidencias.SelectedRows.Count == 1)
            {
                if (modoAdmin == 0)
                {
                    incid = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0].Value));
                    Modificar_Incidencias_Ajenas mod = new Modificar_Incidencias_Ajenas(incid);
                    mod.ShowDialog();
                }
                else if (modoAdmin == 1)
                {
                    incid = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0].Value));
                    Modificar_Incidencias_Propias mod = new Modificar_Incidencias_Propias(incid);
                    mod.ShowDialog();
                }
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            Incidencias incidenciaBorrar = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0]));
            DialogResult r = MessageBox.Show("¿Estas seguro de borrar esta incidencia?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.OK))
            {
                await controlador_Incidencias.DeleteIncidencias(incidenciaBorrar, Convert.ToString(incidenciaBorrar.num));
            }
        }

        private async void btnInformacion_Click(object sender, EventArgs e)
        {
            Incidencias incid = new Incidencias();
            if (dvgIncidencias.SelectedRows.Count == 1)
            {
                incid = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0].Value));
                Info_Incidencia mod = new Info_Incidencia(incid);
                mod.ShowDialog();
            }
        }

        private async void btnMisIncidencias_Click(object sender, EventArgs e)
        {
            Perfiles p = await controlador_Perfiles.GetPerfil(recogerCredencialesporDominio());
            List<Incidencias> ListaIncidencia = await controlador_Incidencias.GetAllIncidenciasbyId(Convert.ToString(p.personal_id));
            cargarDgv(ListaIncidencia);
            modoAdmin++;
        }


        private static string recogerCredencialesporDominio()
        {
            var userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] aux = userName.Split('\\');
            string nombreDelUsuario = aux[aux.Length - 1];
            return nombreDelUsuario;
        }
    }
}

using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class CreacionIncidencias : Form
    {
        private int identificadorIncidencia;

        private Controlador_Incidencias_Subtipos controlador_Subtipos;
        private Controlador_Personal controlador_Personal;
        private Controlador_Equipo controlador_Equipo;

        private Incidencias incidencia;
        private Perfiles perfilUsuario;

        public CreacionIncidencias(int i, Perfiles p)
        {
            identificadorIncidencia = i;

            perfilUsuario = p;
            incidencia = new Incidencias();

            controlador_Subtipos = new Controlador_Incidencias_Subtipos();
            controlador_Personal = new Controlador_Personal();
            controlador_Equipo = new Controlador_Equipo();

            InitializeComponent();
            cargarCondiciones(false);
            CargarComboBox();
            cargarDatos();
        }

        private void CreacionIncidencias_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Identificador de la incidencia: " + identificadorIncidencia);
        }
        private void cargarCondiciones(bool e)
        {
            txtNumeroEtiqueta.Enabled = e;
            txtAula.Enabled = e;
            txtPuesto.Enabled = e;

        }
        private void cbbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTipo.Text.Equals(Convert.ToString(Tipo.Equipos)))
            {
                cargarCondiciones(true);

            }
            else
            {
                cargarCondiciones(false);
            }
            cargarNombresSubtipos(cbbTipo.Text);
            cbbNombreSubtipo.Text = string.Empty;
            cbbSubSubtipo.Text = string.Empty;
        }
        private void cargarDatos()
        {
            txtFechaCreacion.Text = Convert.ToString(DateTime.Now);
            txtCreador.Text = perfilUsuario.dominio;
        }
        private async void CargarComboBox()
        {
            cbbTipo.Items.Clear();
            Array tipos = Enum.GetValues(typeof(Tipo));
            foreach (Tipo tipo in tipos)
            {
                this.cbbTipo.Items.Add(Convert.ToString(tipo));
            }
            cbbNombreSubtipo.Items.Clear();
            cbbSubSubtipo.Items.Clear();
            cbbNombreSubtipo.Enabled = false;
            cbbSubSubtipo.Enabled = false;

        }
        private async void cargarNombresSubtipos(string tipo)
        {
            List<Incidencias_subtipo> listaSub = await controlador_Subtipos.GetAllIncidenciasSubtipos();
            bool existen = false;
            string[] nombres = new string[listaSub.Count];
            int i = 0;
            this.cbbNombreSubtipo.Items.Clear();
            foreach (Incidencias_subtipo item in listaSub)
            {
                nombres[i] = item.subtipoNombre;
                if (tipo.Equals(Convert.ToString(item.tipo)))
                {
                    if (i != 0)
                    {
                        if (!nombres[i].Equals(nombres[i - 1]))
                        {
                            if (item.subtipoNombre != null)
                            {
                                this.cbbNombreSubtipo.Items.Add(Convert.ToString(item.subtipoNombre));
                                existen = true;
                            }
                        }
                    }
                    else
                    {
                        if (item.subtipoNombre != null)
                        {
                            this.cbbNombreSubtipo.Items.Add(Convert.ToString(item.subtipoNombre));
                            existen = true;
                        }
                    }
                }
                i++;
            }
            if (existen == true)
            {
                cbbNombreSubtipo.Enabled = true;
            }
            else
            {
                cbbNombreSubtipo.Enabled = false;
            }

        }
        private async void cargarSubSubtipos(string subtipos)
        {
            List<Incidencias_subtipo> listaSub = await controlador_Subtipos.GetAllIncidenciasSubtipos();
            bool existen = false;
            this.cbbSubSubtipo.Items.Clear();
            foreach (Incidencias_subtipo item in listaSub)
            {
                if (subtipos.Equals(Convert.ToString(item.subtipoNombre)))
                {
                    if (item.subSubtipo != null)
                    {
                        this.cbbSubSubtipo.Items.Add(Convert.ToString(item.subSubtipo));
                        existen = true;
                    }

                }
            }
            if (existen == true)
            {
                cbbSubSubtipo.Enabled = true;
            }
            else
            {
                cbbSubSubtipo.Enabled = false;
            }

        }
        private void cbbNombreSubtipo_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbSubSubtipo.Text = string.Empty;
            cargarSubSubtipos(cbbNombreSubtipo.Text);
        }
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            if (abrirfile.ShowDialog() == DialogResult.OK)
            {
                byte[] filebytes = File.ReadAllBytes(this.abrirfile.FileName);
                string extension = Path.GetExtension(this.abrirfile.FileName);
                incidencia.archivoBase64 = Convert.ToBase64String(filebytes);
                incidencia.extension = extension;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarCBByPersonal();
            guardarAsync();
            incidencia.fechaCreacion = Convert.ToDateTime(txtFechaCreacion.Text);
            incidencia.descripcion = txtDescripcion.Text;
            if (incidencia.extension!=null&&incidencia.archivoBase64!=null)
            {

            }
            else
            {
                MessageBox.Show("No has seleccionado");
            }

        }
        private async void guardarCBByPersonal()
        {
            List<Incidencias_subtipo> listaSub = await controlador_Subtipos.GetAllIncidenciasSubtipos();
            foreach (Incidencias_subtipo item in listaSub)
            {
                if (cbbNombreSubtipo.Text.Equals(Convert.ToString(item.subtipoNombre)) && cbbSubSubtipo.Text.Equals(Convert.ToString(item.tipo)))
                {
                    incidencia.incidenciasSubtipo = item;
                }
            }
        }
        private async void guardarAsync()
        {
            incidencia.personal1 = await controlador_Personal.GetPersonal(Convert.ToString(perfilUsuario.personalId));
            incidencia.equipo = await controlador_Equipo.GetEquipoPorEtiqueta(txtNumeroEtiqueta.Text);
        }
    }
}

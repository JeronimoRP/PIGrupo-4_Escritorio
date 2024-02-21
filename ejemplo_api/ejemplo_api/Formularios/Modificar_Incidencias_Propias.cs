using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.IO;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class Modificar_Incidencias_Propias : Form
    {


        public Incidencias incidencia;
        private Incidencias incidenciaModificada;

        private Controlador_Incidencias controlador_Incidencias;
        private Controlador_Incidencias_Subtipos Controlador_Incidencias_Subtipos;
        private Controlador_Personal Controlador_Personal;
        private Controlador_Equipo Controlador_Equipo;

        private byte[] filebytes;
        private string extension;

        public Modificar_Incidencias_Propias(Incidencias incid)
        {
            InitializeComponent();
            incidencia = new Incidencias();
            this.incidencia = incid;
            Controlador_Incidencias_Subtipos = new Controlador_Incidencias_Subtipos();
            Controlador_Personal = new Controlador_Personal();
            Controlador_Equipo = new Controlador_Equipo();
            controlador_Incidencias = new Controlador_Incidencias();
            cargarComboBoxs();
            cargardatos();
        }

        private async void cargardatos()
        {
            txtId.Text = Convert.ToString(incidencia.num);
            cbbTipo.Text = Convert.ToString(incidencia.tipo);
            txtSubtipo.Text = Convert.ToString(incidencia.incidenciasSubtipo.subSubtipo);
            txtFechaCreacion.Text = Convert.ToString(incidencia.fechaCreacion.ToString());

            if (incidencia.fechaCierre != null)
                txtFechaCierre.Text = Convert.ToString(incidencia.fechaCierre.ToString());
            txtDescripcion.Text = incidencia.descripcion;
            txtEstado.Text = incidencia.estado.ToString();

            if (incidencia.adjunto_ul != null)
                txtArchivoUrl.Text = incidencia.adjunto_ul;
            txtCreador.Text = incidencia.personal1.apellido1+ ", " + incidencia.personal1.nombre;

            if (incidencia.personal2 != null)
                txtResponsable.Text = incidencia.personal2.apellido1 + ", " + incidencia.personal2.nombre;
            txtEquipo.Text = incidencia.equipo.etiqueta;
            if (txtEstado.Text.Equals(Estado.Cerrada) || txtEstado.Text.Equals(Estado.Resuelta))
                txtTiempoDec.Text = incidencia.tiempo_dec.ToString();
            else if (txtEstado.Equals(Estado.Enproceso) || txtEstado.Text.Equals(Estado.Enviada_A_INFORTEC))
                txtTiempoDec.Text = "En proceso";
            else
                txtTiempoDec.Text = "En espera";
        }

        private async void cargarDatosModificados()
        {
            incidenciaModificada = incidencia;
            Array tipos = Enum.GetValues(typeof(Tipo));
            foreach (Tipo tipo in tipos)
            {
                if (cbbTipo.Text.Equals(tipo.ToString()))
                {
                    incidenciaModificada.tipo = tipo;
                }
            }

            incidenciaModificada.descripcion = txtDescripcion.Text;
            incidenciaModificada.adjunto_ul = txtArchivoUrl.Text;

            
            incidenciaModificada.archivoBase64 = Convert.ToBase64String(filebytes);
            incidenciaModificada.extension = extension;


        }
        private void cargarComboBoxs()
        {
            cbbTipo.Items.Clear();
            Array tipos = Enum.GetValues(typeof(Tipo));
            foreach (var tipo in tipos)
            {
                this.cbbTipo.Items.Add(tipo);
            }
        }

        private void cbbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarDatosModificados();
            if (incidencia != incidenciaModificada)
            {
                DialogResult r = MessageBox.Show("No has guardado los cambios que has realizado en la incidencia, ¿quieres guandarlos?", "Cambios en la incidencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.No)
                {
                    this.Close();
                }
                else if (r == DialogResult.Yes)
                {
                    controlador_Incidencias.PostIncidencias(incidenciaModificada);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarDatosModificados();
            controlador_Incidencias.PostIncidencias(incidenciaModificada);
        }

        private void Modificar_Incidencias_Propias_Load(object sender, EventArgs e)
        {

        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            if (abrirfile.ShowDialog() == DialogResult.OK)
            {
                filebytes = File.ReadAllBytes(this.abrirfile.FileName);
                extension = Path.GetExtension(this.abrirfile.FileName);
            }
        }
    }
}

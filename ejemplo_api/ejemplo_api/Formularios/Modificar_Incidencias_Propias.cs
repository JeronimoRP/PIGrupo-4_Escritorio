using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class Modificar_Incidencias_Propias : Form
    {

        
        public  Incidencias incidencia;
        private Incidencias incidenciaModificada;

        private Controlador_Incidencias controlador_Incidencias;
        private Controlador_Incidencias_Subtipos Controlador_Incidencias_Subtipos;
        private Controlador_Personal Controlador_Personal;
        private Controlador_Equipo Controlador_Equipo;

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
            Incidencias_subtipo incidencias_Subtipo = new Incidencias_subtipo();
            //incidencias_Subtipo = await Controlador_Incidencias_Subtipos.GetIncidenciaSubtipo(Convert.ToString(incidencia.subtipo_id));
            Personal personalCreador = new Personal();
            personalCreador = await Controlador_Personal.GetPersonal(Convert.ToString(incidencia.personal1.id));
            Equipo equipo = await Controlador_Equipo.Getequipo(Convert.ToString(incidencia.equipo_id));
            Personal personalResponsable = new Personal();
            personalResponsable = await Controlador_Personal.GetPersonal(Convert.ToString(incidencia.personal2.id));

            txtId.Text = Convert.ToString(incidencia.num);
            cbbTipo.Text = Convert.ToString(incidencia.tipoIncidencia);
            //cbbSubtipo.Text = Convert.ToString(incidencia.subtipo_id.sub_subtipo);
            txtFechaCreacion.Text = Convert.ToString(incidencia.fecha_creacion.ToString());

            if(incidencia.fecha_cierre!=null)
                txtFechaCierre.Text = Convert.ToString(incidencia.fecha_cierre.ToString());
            txtDescripcion.Text = incidencia.descripcion;
            txtEstado.Text =incidencia.tipoEstado.ToString();

            if(incidencia.adjunto_ul!=null)
                txtArchivoUrl.Text = incidencia.adjunto_ul;
            txtCreador.Text = personalCreador.apellido1.ToString() + ", " + personalCreador.nombre.ToString();

            if(incidencia.personal2!=null)
                txtResponsable.Text = personalResponsable.apellido1 + ", " + personalResponsable.nombre;
            //txtEquipo.Text = equipo.etiqueta;
            if (txtEstado.Text.Equals(Estado.Cerrada) || txtEstado.Text.Equals(Estado.Resuelta))
                txtTiempoDec.Text = incidencia.tiempo_dec.ToString();
            else if (txtEstado.Equals(Estado.Enproceso) || txtEstado.Text.Equals(Estado.Enviada_A_INFORTEC))
                txtTiempoDec.Text = "En proceso";
            else
                txtTiempoDec.Text = "En espera";
        }

        private async void cargarDatosModificados()
        {
            //Incidencias_subtipo incidencias_Subtipo = await Controlador_Incidencias_Subtipos.GetIncidenciaSubtipo();
            incidenciaModificada = incidencia;
            Array tipos = Enum.GetValues(typeof(Tipo));
            foreach (Tipo tipo in tipos)
            {
                if (cbbTipo.Text.Equals(tipo.ToString()))
                {
                    incidenciaModificada.tipoIncidencia = tipo;
                }
            }
            Array subtipos = Enum.GetValues(typeof(Subtipo));
            foreach (Subtipo subtipo in subtipos)
            {
                if (cbbSubtipo.Text.Equals(subtipo.ToString()))
                {
                    //incidenciaModificada.subtipo_id = subtipo;
                }
            }

            incidenciaModificada.descripcion = txtDescripcion.Text;
            incidenciaModificada.adjunto_ul = txtArchivoUrl.Text;


        }
        private void cargarComboBoxs()
        {
            cbbTipo.Items.Clear();
            cbbSubtipo.Items.Clear();
            cbbSubtipo.Enabled = false;
            Array tipos = Enum.GetValues(typeof(Tipo));
            foreach (var tipo in tipos)
            {
                this.cbbTipo.Items.Add(tipo);
            }
            Array subtipos = Enum.GetValues(typeof(Subtipo));
            foreach (var subtipo in subtipos)
            {
                this.cbbSubtipo.Items.Add(subtipo);
            }
        }

        private void cbbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTipo.SelectedItem.Equals(Tipo.Equipos))
            {
                cbbSubtipo.Enabled = true;
            }
            else
            {
                cbbSubtipo.Enabled = false;
                cbbSubtipo.Text = string.Empty;
            }
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
    }
}

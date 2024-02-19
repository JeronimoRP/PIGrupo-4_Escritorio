using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class Modificar_Incidencias_Ajenas : Form
    {
        public Incidencias incidencia;
        private Incidencias incidenciaModificada;

        private Controlador_Incidencias controlador_Incidencias;
        private Controlador_Incidencias_Subtipos controlador_Incidencias_Subtipos;
        private Controlador_Personal controlador_Personal;
        private Controlador_Equipo controlador_Equipo;
        private Controlador_Perfiles controlador_Perfiles;
        public Modificar_Incidencias_Ajenas(Incidencias incid)
        {
            InitializeComponent();
            incidencia = new Incidencias();
            this.incidencia = incid;
            controlador_Incidencias_Subtipos = new Controlador_Incidencias_Subtipos();
            controlador_Personal = new Controlador_Personal();
            controlador_Equipo = new Controlador_Equipo();
            controlador_Incidencias = new Controlador_Incidencias();
            controlador_Perfiles = new Controlador_Perfiles();
            cargarComboBoxs();
            cargardatos();
        }


        private async void cargardatos()
        {
            Incidencias_subtipo incidencias_Subtipo = new Incidencias_subtipo();
            //incidencias_Subtipo = await Controlador_Incidencias_Subtipos.GetIncidenciaSubtipo(Convert.ToString(incidencia.subtipo_id));
            Personal personalCreador = new Personal();
            personalCreador = await controlador_Personal.GetPersonal(Convert.ToString(incidencia.personal1.id));
            Equipo equipo = await controlador_Equipo.Getequipo(Convert.ToString(incidencia.equipo_id));
            Personal personalResponsable = new Personal();
            personalResponsable = await controlador_Personal.GetPersonal(Convert.ToString(incidencia.personal2.id));

            txtId.Text = Convert.ToString(incidencia.num);
            cbbEstado.Text = Convert.ToString(incidencia.tipoEstado);
            //cbbSubtipo.Text = Convert.ToString(incidencia.subtipo_id.sub_subtipo);
            txtFechaCreacion.Text = Convert.ToString(incidencia.fecha_creacion.ToString());

            if (incidencia.fecha_cierre != null)
                txtFechaCierre.Text = Convert.ToString(incidencia.fecha_cierre.ToString());
            txtDescripcion.Text = incidencia.descripcion;
            txtEstado.Text = incidencia.tipoEstado.ToString();

            if (incidencia.adjunto_ul != null)
                txtArchivoUrl.Text = incidencia.adjunto_ul;
            txtCreador.Text = personalCreador.apellido1.ToString() + ", " + personalCreador.nombre.ToString();

            if (incidencia.personal2 != null)
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
            incidenciaModificada = incidencia;
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (Estado estado in estados)
            {
                if (cbbEstado.Text.Equals(estado.ToString()))
                {
                    incidenciaModificada.tipoEstado = estado;
                }
            }
            Perfiles per = new Perfiles();
            per = await controlador_Perfiles.GetPerfil(txtResponsable.Text);

            incidenciaModificada.personal2.id = per.personal_id;


        }

        private void cargarComboBoxs()
        {
            cbbEstado.Items.Clear();
            cbbEstado.Enabled = false;
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (var estado in estados)
            {
                this.cbbEstado.Items.Add(estado);
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarDatosModificados();
            if (incidenciaModificada.personal2==null)
            {
                MessageBox.Show("El responsable que has seleccionado no se encuentra en la base de datos", "Error en el responsable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                controlador_Incidencias.PostIncidencias(incidenciaModificada);
                MessageBox.Show("La informacion se ha guardado con exito");
            }
        }


        private void Modificar_Incidencias_Ajenas_Load(object sender, EventArgs e)
        {

        }
    }
}

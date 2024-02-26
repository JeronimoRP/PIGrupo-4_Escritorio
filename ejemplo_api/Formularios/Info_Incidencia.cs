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
    public partial class Info_Incidencia : Form
    {
        public Incidencias incidencia;
        private Incidencias incidenciaModificada;

        private Controlador_Incidencias controlador_Incidencias;
        private Controlador_Incidencias_Subtipos Controlador_Incidencias_Subtipos;
        private Controlador_Personal Controlador_Personal;
        private Controlador_Equipo Controlador_Equipo;
        public Info_Incidencia(Incidencias incid)
        {
            InitializeComponent();
            incidencia = new Incidencias();
            this.incidencia = incid;
            Controlador_Incidencias_Subtipos = new Controlador_Incidencias_Subtipos();
            Controlador_Personal = new Controlador_Personal();
            Controlador_Equipo = new Controlador_Equipo();
            controlador_Incidencias = new Controlador_Incidencias();
            cargarInformacion();
        }

        private void Info_Incidencia_Load(object sender, EventArgs e)
        {

        }
        private async void cargarInformacion()
        {
            txtId.Text = Convert.ToString(incidencia.num);
            txtTipo.Text = Convert.ToString(incidencia.tipo);
            txtSubtipo.Text = Convert.ToString(incidencia.incidenciasSubtipo.subSubtipo);
            txtFechaCreacion.Text = Convert.ToString(incidencia.fechaCreacion.ToString());

            if (incidencia.fechaCierre != null)
                txtFechaCierre.Text = Convert.ToString(incidencia.fechaCierre.ToString());
            txtDescripcion.Text = incidencia.descripcion;
            txtEstado.Text = incidencia.estado.ToString();

            if (incidencia.adjunto_ul != null)
                txtArchivoUrl.Text = incidencia.adjunto_ul;
            txtCreador.Text = incidencia.personal1.apellido1.ToString() + ", " + incidencia.personal1.nombre.ToString();

            if (incidencia.personal2 != null)
                txtResponsable.Text = incidencia.personal2.apellido1 + ", " + incidencia.personal2.nombre;
            txtEquipo.Text = incidencia.equipo.tipoEquipo.ToString();

            if (txtEstado.Text.Equals(Estado.Cerrada) || txtEstado.Text.Equals(Estado.Resuelta))
                txtTiempoDec.Text = incidencia.tiempo_dec.ToString();
            else if (txtEstado.Equals(Estado.En_proceso) || txtEstado.Text.Equals(Estado.Enviada_A_INFORTEC))
                txtTiempoDec.Text = "En proceso";
            else
                txtTiempoDec.Text = "No esta en proceso";

        }
    }
}

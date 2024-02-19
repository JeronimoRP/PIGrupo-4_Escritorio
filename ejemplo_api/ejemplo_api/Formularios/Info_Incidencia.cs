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
            Incidencias_subtipo incidencias_Subtipo = new Incidencias_subtipo();
            //incidencias_Subtipo = await Controlador_Incidencias_Subtipos.GetIncidenciaSubtipo(Convert.ToString(incidencia.subtipo_id));
            Personal personalCreador = new Personal();
            personalCreador = await Controlador_Personal.GetPersonal(Convert.ToString(incidencia.personal1.id));
            Equipo equipo = await Controlador_Equipo.Getequipo(Convert.ToString(incidencia.equipo_id));
            Personal personalResponsable = new Personal();
            personalResponsable = await Controlador_Personal.GetPersonal(Convert.ToString(incidencia.personal2.id));

            txtId.Text = Convert.ToString(incidencia.num);
            txtTipo.Text = Convert.ToString(incidencia.tipoIncidencia);
            //txtSubtipo.Text = Convert.ToString(incidencia.subtipo_id.sub_subtipo);
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
            //txtEquipo.Text = equipo.tipoEquipo.ToString();

            if (txtEstado.Text.Equals(Estado.Cerrada) || txtEstado.Text.Equals(Estado.Resuelta))
                txtTiempoDec.Text = incidencia.tiempo_dec.ToString();
            else if (txtEstado.Equals(Estado.Enproceso) || txtEstado.Text.Equals(Estado.Enviada_A_INFORTEC))
                txtTiempoDec.Text = "En proceso";
            else
                txtTiempoDec.Text = "No esta en proceso";
                
        }
    }
}

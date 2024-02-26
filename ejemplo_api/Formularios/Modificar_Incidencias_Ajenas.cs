using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class Modificar_Incidencias_Ajenas : Form
    {
        public Incidencias incidencia;
        private Incidencias incidenciaModificada;

        private Personal responsable;
        private Personal creador;

        private Perfiles creadorPerfil;
        private Perfiles responsablePerfil;


        private Controlador_Incidencias controlador_Incidencias;
        private Controlador_Personal controlador_Personal;
        private Controlador_Perfiles controlador_Perfiles;
        public Modificar_Incidencias_Ajenas(Incidencias incidencias)
        {
            InitializeComponent();
            incidencia = new Incidencias();
            this.incidencia = incidencias;

            responsable = new Personal();
            creador = new Personal();
            creadorPerfil = new Perfiles();
            responsablePerfil = new Perfiles();

            controlador_Personal = new Controlador_Personal();
            controlador_Incidencias = new Controlador_Incidencias();
            controlador_Perfiles = new Controlador_Perfiles();
            cargarComboBoxs();
            cargardatos();
            cargarPerfiles();
        }
        private async void cargardatos()
        {

            if (incidencia.fechaCierre != null)
            {
                string fechaFormatoSql = Convert.ToDateTime(incidencia.fechaCierre).ToString("yyyy-MM-ddTHH:mm:ss.fff");
                string diaHoy = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");

                TimeSpan datadif = Convert.ToDateTime(diaHoy) - Convert.ToDateTime(fechaFormatoSql);
                int days = (int)datadif.TotalDays;
                if (days >= 1)
                {
                    incidencia.estado = Estado.Cerrada;
                    await controlador_Incidencias.PostIncidencia(incidencia);
                }
            }


            txtId.Text = Convert.ToString(incidencia.num);
            cbbEstado.Text = Convert.ToString(incidencia.estado);
            txtsubtipo.Text = Convert.ToString(incidencia.incidenciasSubtipo.subSubtipo);
            txtFechaCreacion.Text = Convert.ToString(incidencia.fechaCreacion.ToString());
            txtEquipo.Text = incidencia.equipo.etiqueta;

            if (incidencia.fechaCierre != null)
                txtFechaCierre.Text = Convert.ToString(incidencia.fechaCierre.ToString());
            txtDescripcion.Text = incidencia.descripcion;


            if (incidencia.adjunto_ul != null)
                txtArchivoUrl.Text = incidencia.adjunto_ul;
            txtCreador.Text = incidencia.personal1.apellido1 + ", " + incidencia.personal1.nombre;
            txtEquipo.Text = incidencia.equipo.etiqueta;
            if (txtsubtipo.Text.Equals(Estado.Cerrada) || txtsubtipo.Text.Equals(Estado.Resuelta))
                txtHora.Text = incidencia.tiempo_dec.ToString();
            else if (txtsubtipo.Equals(Estado.En_proceso) || txtsubtipo.Text.Equals(Estado.Enviada_A_INFORTEC))
                txtHora.Text = "En proceso";
            else
                txtHora.Text = "En espera";
        }
        private async void cargarDatosModificados()
        {
            incidenciaModificada = incidencia;
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (Estado estado in estados)
            {
                if (cbbEstado.Text.Equals(Convert.ToString(estado)))
                {
                    incidenciaModificada.estado = estado;
                }
            }
            Perfiles per = new Perfiles();
            List<Personal> perfiles = await controlador_Personal.GetAllPersonal();
            string nombre = "";
            foreach (Personal item in perfiles)
            {
                nombre = item.apellido1 + ", " + item.nombre;
                if (nombre.Equals(cbbResponsable.Text))
                {
                    incidenciaModificada.personal2 = item;
                }
            }
            CargarDuracion();
        }
        private async void cargarComboBoxs()
        {
            cbbEstado.Items.Clear();
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (Estado estado in estados)
            {
                this.cbbEstado.Items.Add(estado);
            }

            List<Perfiles> lista = await controlador_Perfiles.GetAllPerfiles();
            Personal per = new Personal();
            string nombre = "";
            cbbResponsable.Items.Clear();

            foreach (Perfiles item in lista)
            {
                if (item.tipoPerfil.Equals(Perfil.Administrador))
                {
                    per = await controlador_Personal.GetPersonal(Convert.ToString(item.personalId));
                    nombre = per.apellido1 + ", " + per.nombre;
                    cbbResponsable.Items.Add(nombre);
                }
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
                    controlador_Incidencias.PostIncidencia(incidenciaModificada);
                }
            }
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarDatosModificados();
            if (incidenciaModificada.personal2 == null)
            {
                MessageBox.Show("El responsable que has seleccionado no se encuentra en la base de datos", "Error en el responsable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (incidenciaModificada.personal2 == null && !incidenciaModificada.estado.Equals(Estado.Abierta))
            {
                MessageBox.Show("Para el estado que has escogido, se necesita un responsable", "Error en el responsable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (incidenciaModificada.personal2 != null && incidenciaModificada.estado.Equals(Estado.Abierta))
            {
                MessageBox.Show("Para el estado que has escogido, no se necesita un responsable. Cambia el estado que has escogido para poder seguir", "Error en el responsable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }else if (cbbEstado.Text.Equals(Estado.Resuelta)&&incidenciaModificada.tiempo_dec.Equals(string.Empty))
            {
                MessageBox.Show("Rellena el campo restante en el tiempo dedicado a la incidencia");
            }
            else
            {
                controlador_Incidencias.PostIncidencia(incidenciaModificada);
                
                if (incidenciaModificada.estado.Equals(Estado.Resuelta))
                {
                    enviarNotificacionAUsuario();
                    MessageBox.Show("La informacion se ha guardado con exito y se le envio un correo al propietario de la incidencia");
                }
                else
                {
                    MessageBox.Show("La informacion se ha guardado con exito");
                }
            }
        }
        private void Modificar_Incidencias_Ajenas_Load(object sender, EventArgs e)
        {

        }
        private void cbbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbEstado.Text.Equals(Convert.ToString(Estado.Resuelta)))
            {
                txtFechaCierre.Text = Convert.ToString(DateTime.Now);
            }
        }
        private async void cargarPerfiles()
        {
            List<Personal> personals = await controlador_Personal.GetAllPersonal();
            string nombre = "";
            foreach (Personal item in personals)
            {
                nombre = item.apellido1 + ", " + item.nombre;
                if (nombre.Equals(cbbResponsable.Text))
                {
                    responsable = item;
                }
                if (nombre.Equals(txtCreador.Text))
                {
                    creador = item;
                }
            }
            List<Perfiles> perfiles = await controlador_Perfiles.GetAllPerfiles();
            foreach (Perfiles item in perfiles)
            {
                if (item.personalId == responsable.id)
                {
                    responsablePerfil = item;
                }
                if (item.personalId == creador.id)
                {
                    creadorPerfil = item;
                }
            }

        }
        private void enviarNotificacionAUsuario()
        {
            var fromAddress = new MailAddress(responsablePerfil.educantabria, "From Name");
            var toAddress = new MailAddress(creadorPerfil.educantabria, "To Name");
            string fromPassword = responsablePerfil.password;
            string subject = "Incidencia Nª" + incidenciaModificada.num;
            string body = "La incidencia nº" + incidenciaModificada.num + " ha sido realizada, entre dentro de la incidencia en " +
                "menos de un dia por si acaso no esta contento con los resultados";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        private void CargarDuracion()
        {
            if (txtHora.Equals(string.Empty) || txtMinutos.Equals(string.Empty) || txtsegundos.Equals(string.Empty))
            {

                incidenciaModificada.tiempo_dec = string.Empty;
            }
            else
            {
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int day = DateTime.Now.Day;
                int hour = Convert.ToInt32(txtHora.Text);
                int minute = Convert.ToInt32(txtMinutos.Text);
                int second = Convert.ToInt32(txtsegundos.Text);
                DateTime dateTime = new DateTime(year, month, day, hour, minute, second);
                incidenciaModificada.tiempo_dec = dateTime.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            }
        }
    }
}

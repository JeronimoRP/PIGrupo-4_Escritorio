using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using MimeKit;
using Proyecto.Vistas;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class Administrador : Form
    {
        private Controlador_Incidencias controlador_Incidencias;
        private Controlador_Perfiles controlador_Perfiles;
        private Controlador_Incidencias_Subtipos controlador_Incidencias_Subtipos;
        private Controlador_Personal controlador_Personal;

        private List<Incidencias> lista_Incidencias;

        public Incidencias incidencias;
        private Perfiles p;


        private DateTime dia;
        private int modoAdmin = 0;
        public Administrador()
        {
            controlador_Incidencias = new Controlador_Incidencias();
            controlador_Perfiles = new Controlador_Perfiles();
            controlador_Incidencias_Subtipos = new Controlador_Incidencias_Subtipos();
            controlador_Personal = new Controlador_Personal();

            lista_Incidencias = new List<Incidencias>();

            incidencias = new Incidencias();
            p = new Perfiles();


            InitializeComponent();
            cargarComboBoxs();
            cargarListaIncidencias();
            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "yyyy-MM-dd";
            cargarPerfil();
        }
        private void cargarComboBoxs()
        {
            cbbTipo.Items.Clear();
            cbbEstado.Items.Clear();
            Array tipos = Enum.GetValues(typeof(Tipo));
            foreach (Tipo tipo in tipos)
            {
                this.cbbTipo.Items.Add(Convert.ToString(tipo));
            }
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (Estado estado in estados)
            {
                this.cbbEstado.Items.Add(Convert.ToString(estado));
            }
            dia = dtp1.Value;
        }
        private async void cargarPerfil()
        {
            p = await controlador_Perfiles.GetPerfil(recogerCredencialesporDominio());
        }
        private async void cargarListaIncidencias()
        {
            lista_Incidencias = await
                controlador_Incidencias.GetAllIncidencias();
            cargarDgv(lista_Incidencias);
        }
        private async void cbbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbSubtipo.Items.Clear();
            List<Incidencias_subtipo> listaSub = await controlador_Incidencias_Subtipos.GetAllIncidenciasSubtipos();
            string[] nombres = new string[listaSub.Count];
            int i = 0;
            foreach (Incidencias_subtipo item in listaSub)
            {
                nombres[i] = item.subtipoNombre;
                if (cbbTipo.Text.Equals(Convert.ToString(item.tipo)))
                {
                    if (i != 0)
                    {
                        if (!nombres[i].Equals(nombres[i - 1]))
                        {
                            if (item.subtipoNombre != null)
                            {
                                cbbSubtipo.Items.Add(Convert.ToString(item.subtipoNombre));
                            }
                        }
                    }
                    else
                    {
                        if (item.subtipoNombre != null)
                        {
                            cbbSubtipo.Items.Add(Convert.ToString(item.subtipoNombre));
                        }
                    }
                }
                i++;
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
                    if (incidencia.personal2 == null)
                        row.Cells[2].Value = "Sin responsable";
                    else
                        row.Cells[2].Value = incidencia.personal2.nombre;
                    row.Cells[3].Value = incidencia.tipo;
                    row.Cells[4].Value = incidencia.estado;
                    row.Cells[5].Value = incidencia.fechaCreacion;
                    row.Cells[6].Value = incidencia.fechaCierre;

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
            if (dia == dtp1.Value)
            {


                lista = await controlador_Incidencias.GetAllIncidenciasPorFiltro(cbbTipo.Text, cbbEstado.Text, cbbSubtipo.Text);
            }
            else
            {
                DateTime fecha = dtp1.Value;
                string fechaFormatoSql = fecha.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                lista = await controlador_Incidencias.GetAllIncidenciasPorFiltro(cbbTipo.Text,
                    cbbEstado.Text, cbbSubtipo.Text, fechaFormatoSql);


            }
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
            cbbTipo.Text = string.Empty;
            dtp1.Value = dia;
            cargarListaIncidencias();
        }
        private async void btnModificar_Click(object sender, EventArgs e)
        {

            if (dvgIncidencias.SelectedRows.Count == 1)
            {
                if (modoAdmin == 0)
                {
                    incidencias = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0].Value));
                    Modificar_Incidencias_Ajenas mod = new Modificar_Incidencias_Ajenas(incidencias);
                    mod.ShowDialog();
                }
                else if (modoAdmin == 1)
                {
                    incidencias = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0].Value));
                    if (incidencias.estado.Equals(Estado.Asignada) || incidencias.estado.Equals(Estado.Abierta))
                    {
                        Modificar_Incidencias_Propias mod = new Modificar_Incidencias_Propias(incidencias);
                        mod.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar esta interfaz ya que es estado es esta, esta en proceso", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
            }
        }
        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            Incidencias incidenciaBorrar = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0].Value));
            DialogResult r = MessageBox.Show("¿Estas seguro de borrar esta incidencia?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r.Equals(DialogResult.OK))
            {
                await controlador_Incidencias.DeleteIncidencias(incidenciaBorrar, Convert.ToString(incidenciaBorrar.num));
            }
            cargarListaIncidencias();
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
            p = await controlador_Perfiles.GetPerfil(recogerCredencialesporDominio());
            if (p == null)
            {
                MessageBox.Show("No estas dentro de la base de datos por lo que no posees ninguna incidencia", "Error al recoger incidencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (modoAdmin == 0)
                {
                    btnMisIncidencias.Text = "MODO PROFESOR";
                    List<Incidencias> ListaIncidencia = await controlador_Incidencias.GetAllIncidenciasbyId(Convert.ToString(p.personalId));
                    cargarDgv(ListaIncidencia);
                    modoAdmin++;
                }
                else
                {
                    btnMisIncidencias.Text = "MODO ADMINISTRADOR";
                    cargarListaIncidencias();
                    modoAdmin--;
                }

            }

        }
        private static string recogerCredencialesporDominio()
        {
            var userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] aux = userName.Split('\\');
            string nombreDelUsuario = aux[aux.Length - 1];
            return nombreDelUsuario;
        }
        private async void btnCrear_Click(object sender, EventArgs e)
        {
            p = await controlador_Perfiles.GetPerfil(recogerCredencialesporDominio());
            CreacionIncidencias creacion = new CreacionIncidencias(lista_Incidencias.Count + 1, p);
            creacion.ShowDialog();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnEnviarGmail_Click(object sender, EventArgs e)
        {

            var fromAddress = new MailAddress(p.educantabria, "From Name");
            var toAddress = new MailAddress(p.educantabria, "To Name");
            const string fromPassword = "FRAGUAS1diego!";
            const string subject = "hola";
            const string body = "tonto el que lo lea";
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
        private async void btnComentar_Click(object sender, EventArgs e)
        {
            Incidencias incid = new Incidencias();
            incid = await controlador_Incidencias.GetIncidencia(Convert.ToString(dvgIncidencias.CurrentRow.Cells[0].Value));
            Personal persona = new Personal();
            persona = await controlador_Personal.GetPersonal(Convert.ToString(p.personalId));
            Comentarios comentarios = new Comentarios(incid, persona);
            comentarios.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Informes informe = new Informes();
            informe.ShowDialog();
        }
    }
}

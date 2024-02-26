using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private Controlador_Incidencias controlador_Incidencias;

        private Incidencias incidencia;
        private Perfiles perfilUsuario;
        private Timer timer;
        public CreacionIncidencias(int i, Perfiles p)
        {
            identificadorIncidencia = i;

            perfilUsuario = p;
            incidencia = new Incidencias();

            controlador_Subtipos = new Controlador_Incidencias_Subtipos();
            controlador_Personal = new Controlador_Personal();
            controlador_Equipo = new Controlador_Equipo();
            controlador_Incidencias = new Controlador_Incidencias();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tic;
            timer.Start();

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
        private async void cargarDatos()
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
        private void Timer_tic(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool cond = await condicionesCumplidas();
            if (cond == true)
            {
                guardarCBB();
                guardarAsync();
                DateTime fecha =DateTime.Now;
                incidencia.fechaCreacion = fecha.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                incidencia.descripcion = txtDescripcion.Text;
                incidencia.estado = Estado.Abierta;
                await controlador_Incidencias.PostIncidencia(incidencia);
                MessageBox.Show("Se ha guardado la incidencia correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
        private async void guardarCBB()
        {
            List<Incidencias_subtipo> listaSub = await controlador_Subtipos.GetAllIncidenciasSubtipos();
            foreach (Incidencias_subtipo item in listaSub)
            {
                if ((cbbTipo.Text.Equals(Convert.ToString(item.tipo)) && cbbNombreSubtipo.Text.Equals(Convert.ToString(item.subtipoNombre)) && cbbSubSubtipo.Text.Equals(Convert.ToString(item.tipo))) ||
                    cbbTipo.Text.Equals(Convert.ToString(item.tipo)) && cbbNombreSubtipo.Text.Equals(Convert.ToString(item.subtipoNombre)))
                {
                    incidencia.incidenciasSubtipo = item;
                }
            }
        }
        private async void guardarAsync()
        {
            incidencia.personal1 = await controlador_Personal.GetPersonal(Convert.ToString(perfilUsuario.personalId));
        }
        private async Task<bool> condicionesCumplidas()
        {
            bool condiciones_cumplidas = false;
            string camposRellenar = string.Empty;
            string equipo = string.Empty;
            if (!cbbTipo.Text.Equals(string.Empty))
            {
                lblTipo.ForeColor = Color.Black;
                if (cbbTipo.Text.Equals(Convert.ToString(Tipo.Equipos)))
                {
                    incidencia.equipo = await controlador_Equipo.GetEquipoPorEtiqueta(txtNumeroEtiqueta.Text);
                    if (incidencia.equipo == null)
                    {
                        equipo = "El equipo que has seleccionado no existe en nuestra base de datos.";
                    }
                }
            }
            else
            {
                lblTipo.ForeColor = Color.Red;
                camposRellenar += "Tipo ";

            }
            if (!cbbNombreSubtipo.Text.Equals(string.Empty))
            {
                lblNombreSubtipo.ForeColor = Color.Black;
            }
            else
            {
                lblNombreSubtipo.ForeColor = Color.Red;
                if (camposRellenar.Equals(string.Empty))
                {
                    camposRellenar += "Nombre del subtipo ";
                }
                else
                {
                    camposRellenar += "- Nombre del subtipo ";
                }

            }
            if ((cbbSubSubtipo.Enabled == true && !cbbSubSubtipo.Text.Equals(string.Empty)) || cbbSubSubtipo.Enabled == false)
            {
                lblSubsubtipo.ForeColor = Color.Black;
            }
            else
            {
                lblSubsubtipo.ForeColor = Color.Red;
                if (camposRellenar.Equals(string.Empty))
                {
                    camposRellenar += "Subsubtipo ";
                }
                else
                {
                    camposRellenar += "- Subsubtipo ";
                }
            }
            if (txtDescripcion.Text.Equals(string.Empty))
            {
                lblDescripcion.ForeColor = Color.Red;
                if (camposRellenar.Equals(string.Empty))
                {
                    camposRellenar += "Descripción ";
                }
                else
                {
                    camposRellenar += "- Descripción ";
                }
            }
            else
            {
                txtDescripcion.ForeColor = Color.Black;
            }
            if (camposRellenar.Equals(string.Empty)||equipo.Equals(string.Empty))
            {
                condiciones_cumplidas = true;
            }
            else
            {
                MessageBox.Show("Necesitas rellenar los siguientes campos para guardar la incidencia: " + camposRellenar+". "+equipo, "Informacion necesaria", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return condiciones_cumplidas;
        }
    }
}

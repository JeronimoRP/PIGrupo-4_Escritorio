using ejemplo_api.Controles;
using ejemplo_api.Modelos;
using System;
using System.Windows.Forms;

namespace ejemplo_api
{
    public partial class Form1 : Form
    {
        private Controlador_Perfiles controladorPerfiles;
        private Perfiles perfiles;
        public Form1()
        {
            InitializeComponent();
            perfiles = new Perfiles();
            controladorPerfiles = new Controlador_Perfiles();
            informacion_del_usuario();
        }



        private async void GetPerfil(string id)
        {
            Perfiles personaje = new Perfiles();
            personaje = await
                controladorPerfiles.GetPerfil("Alumno");
            if (personaje != null)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dvgPersonajes);
                row.Cells[0].Value = personaje.personalId;
                row.Cells[1].Value = personaje.dominio;
                row.Cells[2].Value = personaje.educantabria;
                row.Cells[3].Value = personaje.password;
                row.Cells[4].Value = personaje.tipoPerfil;

                dvgPersonajes.Rows.Add(row);

            }
            else
            {
                MessageBox.Show("No se pudo obtener la petición. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvgPersonajes.Rows.Clear();
            GetPerfil("Alumno");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvgPersonajes.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dvgPersonajes.Rows.Clear();
        }
        /*
        private async void meterDatos()
        {
            Character per = new Character("1");
            per = await controladorPersonajes.PutCharacters(per);
        }
        private async void actualizarDatos()
        {
            Character per = new Character("1");
            per = await controladorPersonajes.PostCharacters(per);
        }
        private async void borrarDatos()
        {
            Character per = new Character("1");
            per = await controladorPersonajes.DeleteCharacters(per);
        }
        */
        private void informacion_del_usuario()
        {
            var userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] aux = userName.Split('\\');
            string nombreDelUsuario = aux[aux.Length-1];
            label1.Text = nombreDelUsuario;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

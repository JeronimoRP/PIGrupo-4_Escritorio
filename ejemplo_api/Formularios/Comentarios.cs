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
    public partial class Comentarios : Form
    {
        private int modo = 1;

        private Controlador_Comentario controlador_Comentario;
        private List<Comentario> comentarios;

        private Comentario nuevoComentario;
        private Incidencias idIncidencia;
        private Personal personal;

        public Comentarios(Incidencias idIncidencia, Personal personal)
        {
            controlador_Comentario = new Controlador_Comentario();
            comentarios = new List<Comentario>();
            nuevoComentario = new Comentario();
            this.idIncidencia = idIncidencia;
            this.personal = personal;
            InitializeComponent();
            cargarDGV();
        }

        private void dtvListaDeComentarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaDeComentarios.SelectedRows.Count == 1)
            {
                txtTexto.Text = dgvListaDeComentarios.SelectedRows[0].Cells[3].ToString();
            }
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            if (modo == 1)
            {
                btnModo.Text = "NUEVO COMENTARIO";
                txtTexto.Text = string.Empty;
                modo--;
            }
            else
            {
                btnModo.Text = "MODO LECTURA";
                txtTexto.Text = string.Empty;
                modo++;
            }
        }

        private async void cargarDGV()
        {
            comentarios = await controlador_Comentario.GetAllComentarios();
            dgvListaDeComentarios.Rows.Clear();
            foreach (Comentario comentario in comentarios)
            {
                if (comentario.incidencia.num == idIncidencia.num)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvListaDeComentarios);
                    row.Cells[0].Value = comentario.id;
                    row.Cells[1].Value = comentario.fechahora;
                    row.Cells[2].Value = comentario.incidencia.num;
                    row.Cells[3].Value = comentario.texto;
                }
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Equals(string.Empty))
            {
                MessageBox.Show("No has escrito nada en el campo de texto, escribe algo para poder enviar un nuevo comentario", "Error a la hora de crear un nuevo comentario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nuevoComentario.texto = txtTexto.Text;
                nuevoComentario.incidencia = idIncidencia;
                nuevoComentario.personal = personal;
                nuevoComentario.adjuntoUrl = null;
                await controlador_Comentario.PostIncidencia(nuevoComentario);
                MessageBox.Show("Nuevo comentario creado correctamente", "Confirmacion de la creacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTexto.Text = string.Empty;
                cargarDGV();
            }
        }

        private void Comentarios_Load(object sender, EventArgs e)
        {

        }
    }
}

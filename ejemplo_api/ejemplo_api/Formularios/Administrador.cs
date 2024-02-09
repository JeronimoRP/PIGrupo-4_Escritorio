using ejemplo_api.Controles;
using ejemplo_api.ListaDeClases;
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
    public partial class Administrador : Form
    {
        private Controlador_Incidencias controlador_Incidencias;
        private Lista_Incidencias lista_Incidencias;
        private Incidencias incidencias;
        public Administrador()
        {
            controlador_Incidencias = new Controlador_Incidencias();
            lista_Incidencias = new Lista_Incidencias();
            incidencias = new Incidencias();

            InitializeComponent();
            cargarCOmboBoxs();
        }

        private void cargarCOmboBoxs()
        {
            cbbTipo.Items.Clear();
            cbbSubtipo.Items.Clear();
            cbbSubtipo.Enabled = false;
            cbbEstado.Items.Clear();
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
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (var estado in estados)
            {
                this.cbbEstado.Items.Add(estado);
            }
        }
        private async void GetIncidencias()
        {
            lista_Incidencias = await
                controlador_Incidencias.GetAllIncidencias();
            if (lista_Incidencias != null)
            {
                foreach (var incidencia in lista_Incidencias?.lista_Incidencias)
                {/*
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dvgIncidencias);
                    row.Cells[0].Value = incidencia.name;
                    row.Cells[1].Value = incidencia.gender;
                    row.Cells[2].Value = incidencia.species;
                    row.Cells[3].Value = incidencia.origin.name;

                    dvgIncidencias.Rows.Add(row);
                    */
                }
            }
            else
            {
                MessageBox.Show("No se pudo obtener la petición. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void cargarDgv()
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}

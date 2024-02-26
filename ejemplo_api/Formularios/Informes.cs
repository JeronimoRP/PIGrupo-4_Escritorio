using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_api.Formularios
{
    public partial class Informes : Form
    {
        private string url=string.Empty;
        public Informes()
        {
            InitializeComponent();
        }

        private void Informes_Load(object sender, EventArgs e)
        {

        }
        private void tipoDeInforme()
        {
            if (rbtnExcel.Checked==true)
            {
                if (rB1.Checked==true)
                {
                    url = "https://www.google.com";
                }
                if (rB2.Checked == true)
                {
                    url = "";
                }
                if (rB3.Checked == true)
                {
                    url = "";
                }
                if (rB4.Checked == true)
                {
                    url = "";
                }
                if (rB5.Checked == true)
                {
                    url = "";
                }
                if (rB6.Checked == true)
                {
                    url = "";
                }
                if (rB7.Checked == true)
                {
                    url = "";
                }
            }
            else if(rbtnPdf.Checked == true)
            {
                if (rB1.Checked == true)
                {
                    url = "";
                }
                if (rB2.Checked == true)
                {
                    url = "";
                }
                if (rB3.Checked == true)
                {
                    url = "";
                }
                if (rB4.Checked == true)
                {
                    url = "";
                }
                if (rB5.Checked == true)
                {
                    url = "";
                }
                if (rB6.Checked == true)
                {
                    url = "";
                }
                if (rB7.Checked == true)
                {
                    url = "";
                }
            }
        }

        private void btnCrearInforme_Click(object sender, EventArgs e)
        {
            string chromeExe = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            Process.Start(chromeExe,url);
            this.Close();
        }
    }
}

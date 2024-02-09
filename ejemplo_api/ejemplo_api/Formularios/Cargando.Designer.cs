namespace Proyecto.Vistas
{
    partial class Cargando
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCargando = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblEsperar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(118, 34);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(62, 13);
            this.lblCargando.TabIndex = 3;
            this.lblCargando.Text = "Cargando...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(121, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lblEsperar
            // 
            this.lblEsperar.AutoSize = true;
            this.lblEsperar.Location = new System.Drawing.Point(121, 80);
            this.lblEsperar.Name = "lblEsperar";
            this.lblEsperar.Size = new System.Drawing.Size(153, 13);
            this.lblEsperar.TabIndex = 4;
            this.lblEsperar.Text = "Por favor, espere unos minutos";
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 135);
            this.Controls.Add(this.lblEsperar);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.progressBar1);
            this.Name = "Cargando";
            this.Text = "Cargando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblEsperar;
    }
}
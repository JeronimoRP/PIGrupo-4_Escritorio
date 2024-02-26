
namespace ejemplo_api.Formularios
{
    partial class Informes
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
            this.rbtnExcel = new System.Windows.Forms.RadioButton();
            this.rbtnPdf = new System.Windows.Forms.RadioButton();
            this.gbFormato = new System.Windows.Forms.GroupBox();
            this.gbInformes = new System.Windows.Forms.GroupBox();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.rB5 = new System.Windows.Forms.RadioButton();
            this.rB6 = new System.Windows.Forms.RadioButton();
            this.rB7 = new System.Windows.Forms.RadioButton();
            this.btnCrearInforme = new System.Windows.Forms.Button();
            this.gbFormato.SuspendLayout();
            this.gbInformes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnExcel
            // 
            this.rbtnExcel.AutoSize = true;
            this.rbtnExcel.Location = new System.Drawing.Point(23, 64);
            this.rbtnExcel.Name = "rbtnExcel";
            this.rbtnExcel.Size = new System.Drawing.Size(59, 17);
            this.rbtnExcel.TabIndex = 0;
            this.rbtnExcel.Text = "EXCEL";
            this.rbtnExcel.UseVisualStyleBackColor = true;
            // 
            // rbtnPdf
            // 
            this.rbtnPdf.AutoSize = true;
            this.rbtnPdf.Checked = true;
            this.rbtnPdf.Location = new System.Drawing.Point(23, 31);
            this.rbtnPdf.Name = "rbtnPdf";
            this.rbtnPdf.Size = new System.Drawing.Size(46, 17);
            this.rbtnPdf.TabIndex = 1;
            this.rbtnPdf.TabStop = true;
            this.rbtnPdf.Text = "PDF";
            this.rbtnPdf.UseVisualStyleBackColor = true;
            // 
            // gbFormato
            // 
            this.gbFormato.Controls.Add(this.rbtnPdf);
            this.gbFormato.Controls.Add(this.rbtnExcel);
            this.gbFormato.Location = new System.Drawing.Point(28, 32);
            this.gbFormato.Name = "gbFormato";
            this.gbFormato.Size = new System.Drawing.Size(146, 134);
            this.gbFormato.TabIndex = 2;
            this.gbFormato.TabStop = false;
            this.gbFormato.Text = "FORMATO";
            // 
            // gbInformes
            // 
            this.gbInformes.Controls.Add(this.rB7);
            this.gbInformes.Controls.Add(this.rB6);
            this.gbInformes.Controls.Add(this.rB5);
            this.gbInformes.Controls.Add(this.rB4);
            this.gbInformes.Controls.Add(this.rB3);
            this.gbInformes.Controls.Add(this.rB2);
            this.gbInformes.Controls.Add(this.rB1);
            this.gbInformes.Location = new System.Drawing.Point(197, 32);
            this.gbInformes.Name = "gbInformes";
            this.gbInformes.Size = new System.Drawing.Size(312, 206);
            this.gbInformes.TabIndex = 3;
            this.gbInformes.TabStop = false;
            this.gbInformes.Text = "INFORMES";
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Checked = true;
            this.rB1.Location = new System.Drawing.Point(18, 31);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(206, 17);
            this.rB1.TabIndex = 2;
            this.rB1.TabStop = true;
            this.rB1.Text = "Incidencias resueltas por cada usuario";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(18, 54);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(201, 17);
            this.rB2.TabIndex = 3;
            this.rB2.Text = "Incidencias abiertas por cada usuario";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.Location = new System.Drawing.Point(18, 77);
            this.rB3.Name = "rB3";
            this.rB3.Size = new System.Drawing.Size(222, 17);
            this.rB3.TabIndex = 4;
            this.rB3.Text = "Estadisticas sobre los tipos de incidencias";
            this.rB3.UseVisualStyleBackColor = true;
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(18, 100);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(194, 17);
            this.rB4.TabIndex = 5;
            this.rB4.Text = "Tiempo dedicado a cada incidencia";
            this.rB4.UseVisualStyleBackColor = true;
            // 
            // rB5
            // 
            this.rB5.AutoSize = true;
            this.rB5.Location = new System.Drawing.Point(18, 123);
            this.rB5.Name = "rB5";
            this.rB5.Size = new System.Drawing.Size(235, 17);
            this.rB5.TabIndex = 6;
            this.rB5.Text = "Tiempos de resolucion por tipo de incidencia";
            this.rB5.UseVisualStyleBackColor = true;
            // 
            // rB6
            // 
            this.rB6.AutoSize = true;
            this.rB6.Location = new System.Drawing.Point(18, 146);
            this.rB6.Name = "rB6";
            this.rB6.Size = new System.Drawing.Size(217, 17);
            this.rB6.TabIndex = 7;
            this.rB6.Text = "Tiempo dedicado por cada administrador";
            this.rB6.UseVisualStyleBackColor = true;
            // 
            // rB7
            // 
            this.rB7.AutoSize = true;
            this.rB7.Location = new System.Drawing.Point(18, 169);
            this.rB7.Name = "rB7";
            this.rB7.Size = new System.Drawing.Size(279, 17);
            this.rB7.TabIndex = 8;
            this.rB7.Text = "Lista de incidencias asignadas por cada administrador";
            this.rB7.UseVisualStyleBackColor = true;
            // 
            // btnCrearInforme
            // 
            this.btnCrearInforme.Location = new System.Drawing.Point(197, 266);
            this.btnCrearInforme.Name = "btnCrearInforme";
            this.btnCrearInforme.Size = new System.Drawing.Size(134, 59);
            this.btnCrearInforme.TabIndex = 4;
            this.btnCrearInforme.Text = "CREAR INFORME";
            this.btnCrearInforme.UseVisualStyleBackColor = true;
            this.btnCrearInforme.Click += new System.EventHandler(this.btnCrearInforme_Click);
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 357);
            this.Controls.Add(this.btnCrearInforme);
            this.Controls.Add(this.gbInformes);
            this.Controls.Add(this.gbFormato);
            this.Name = "Informes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            this.gbFormato.ResumeLayout(false);
            this.gbFormato.PerformLayout();
            this.gbInformes.ResumeLayout(false);
            this.gbInformes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnExcel;
        private System.Windows.Forms.RadioButton rbtnPdf;
        private System.Windows.Forms.GroupBox gbFormato;
        private System.Windows.Forms.GroupBox gbInformes;
        private System.Windows.Forms.RadioButton rB7;
        private System.Windows.Forms.RadioButton rB6;
        private System.Windows.Forms.RadioButton rB5;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.Button btnCrearInforme;
    }
}
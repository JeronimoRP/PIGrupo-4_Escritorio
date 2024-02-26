
namespace ejemplo_api.Formularios
{
    partial class CreacionIncidencias
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCreador = new System.Windows.Forms.TextBox();
            this.txtArchivoUrl = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroEtiqueta = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNEtiqueta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombreSubtipo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.lblSubsubtipo = new System.Windows.Forms.Label();
            this.cbbNombreSubtipo = new System.Windows.Forms.ComboBox();
            this.cbbSubSubtipo = new System.Windows.Forms.ComboBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.abrirfile = new System.Windows.Forms.OpenFileDialog();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(628, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 46);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(472, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 46);
            this.btnGuardar.TabIndex = 83;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCreador
            // 
            this.txtCreador.Enabled = false;
            this.txtCreador.Location = new System.Drawing.Point(506, 102);
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.Size = new System.Drawing.Size(195, 20);
            this.txtCreador.TabIndex = 79;
            // 
            // txtArchivoUrl
            // 
            this.txtArchivoUrl.Location = new System.Drawing.Point(506, 172);
            this.txtArchivoUrl.Name = "txtArchivoUrl";
            this.txtArchivoUrl.Size = new System.Drawing.Size(123, 20);
            this.txtArchivoUrl.TabIndex = 78;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(98, 211);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(338, 176);
            this.txtDescripcion.TabIndex = 77;
            // 
            // txtNumeroEtiqueta
            // 
            this.txtNumeroEtiqueta.Location = new System.Drawing.Point(134, 172);
            this.txtNumeroEtiqueta.Name = "txtNumeroEtiqueta";
            this.txtNumeroEtiqueta.Size = new System.Drawing.Size(195, 20);
            this.txtNumeroEtiqueta.TabIndex = 76;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Enabled = false;
            this.txtFechaCreacion.Location = new System.Drawing.Point(531, 28);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(195, 20);
            this.txtFechaCreacion.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Creador : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Archivo adjunto :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 222);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 68;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // lblNEtiqueta
            // 
            this.lblNEtiqueta.AutoSize = true;
            this.lblNEtiqueta.Location = new System.Drawing.Point(23, 175);
            this.lblNEtiqueta.Name = "lblNEtiqueta";
            this.lblNEtiqueta.Size = new System.Drawing.Size(106, 13);
            this.lblNEtiqueta.TabIndex = 67;
            this.lblNEtiqueta.Text = "Número de etiqueta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Fecha de creacion : ";
            // 
            // lblNombreSubtipo
            // 
            this.lblNombreSubtipo.AutoSize = true;
            this.lblNombreSubtipo.Location = new System.Drawing.Point(23, 78);
            this.lblNombreSubtipo.Name = "lblNombreSubtipo";
            this.lblNombreSubtipo.Size = new System.Drawing.Size(104, 13);
            this.lblNombreSubtipo.TabIndex = 65;
            this.lblNombreSubtipo.Text = "Nombre del subtipo :";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipo.Location = new System.Drawing.Point(23, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 13);
            this.lblTipo.TabIndex = 64;
            this.lblTipo.Text = "Tipo : ";
            // 
            // cbbTipo
            // 
            this.cbbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(134, 20);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(195, 24);
            this.cbbTipo.TabIndex = 93;
            this.cbbTipo.SelectedValueChanged += new System.EventHandler(this.cbbTipo_SelectedValueChanged);
            // 
            // lblSubsubtipo
            // 
            this.lblSubsubtipo.AutoSize = true;
            this.lblSubsubtipo.Location = new System.Drawing.Point(23, 128);
            this.lblSubsubtipo.Name = "lblSubsubtipo";
            this.lblSubsubtipo.Size = new System.Drawing.Size(72, 13);
            this.lblSubsubtipo.TabIndex = 94;
            this.lblSubsubtipo.Text = "Sub_subtipo: ";
            // 
            // cbbNombreSubtipo
            // 
            this.cbbNombreSubtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNombreSubtipo.FormattingEnabled = true;
            this.cbbNombreSubtipo.Location = new System.Drawing.Point(134, 70);
            this.cbbNombreSubtipo.Name = "cbbNombreSubtipo";
            this.cbbNombreSubtipo.Size = new System.Drawing.Size(195, 24);
            this.cbbNombreSubtipo.TabIndex = 95;
            this.cbbNombreSubtipo.SelectedValueChanged += new System.EventHandler(this.cbbNombreSubtipo_SelectedValueChanged);
            // 
            // cbbSubSubtipo
            // 
            this.cbbSubSubtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubSubtipo.FormattingEnabled = true;
            this.cbbSubSubtipo.Location = new System.Drawing.Point(134, 120);
            this.cbbSubSubtipo.Name = "cbbSubSubtipo";
            this.cbbSubSubtipo.Size = new System.Drawing.Size(195, 24);
            this.cbbSubSubtipo.TabIndex = 96;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(661, 170);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(75, 23);
            this.btnAdjuntar.TabIndex = 97;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(656, 398);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(72, 28);
            this.lblTimer.TabIndex = 98;
            this.lblTimer.Text = "label7";
            // 
            // CreacionIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 433);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.cbbSubSubtipo);
            this.Controls.Add(this.cbbNombreSubtipo);
            this.Controls.Add(this.lblSubsubtipo);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCreador);
            this.Controls.Add(this.txtArchivoUrl);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNumeroEtiqueta);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNEtiqueta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreSubtipo);
            this.Controls.Add(this.lblTipo);
            this.Name = "CreacionIncidencias";
            this.Text = "Nueva incidencía";
            this.Load += new System.EventHandler(this.CreacionIncidencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCreador;
        private System.Windows.Forms.TextBox txtArchivoUrl;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumeroEtiqueta;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNEtiqueta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombreSubtipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.Label lblSubsubtipo;
        private System.Windows.Forms.ComboBox cbbNombreSubtipo;
        private System.Windows.Forms.ComboBox cbbSubSubtipo;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.OpenFileDialog abrirfile;
        private System.Windows.Forms.Label lblTimer;
    }
}
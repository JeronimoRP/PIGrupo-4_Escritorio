
namespace ejemplo_api.Formularios
{
    partial class Administrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.dvgIncidencias = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_de_la_incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_creación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnMisIncidencias = new System.Windows.Forms.Button();
            this.btnComentar = new System.Windows.Forms.Button();
            this.cbbSubtipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTROS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ESTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(521, 42);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(79, 20);
            this.dtp1.TabIndex = 5;
            this.dtp1.Value = new System.DateTime(2024, 2, 20, 0, 0, 0, 0);
            this.dtp1.ValueChanged += new System.EventHandler(this.cambioFiltrado);
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(118, 42);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbbTipo.TabIndex = 7;
            this.cbbTipo.SelectedIndexChanged += new System.EventHandler(this.cambioFiltrado);
            this.cbbTipo.SelectedValueChanged += new System.EventHandler(this.cbbTipo_SelectedValueChanged);
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(245, 41);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbbEstado.TabIndex = 9;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cambioFiltrado);
            // 
            // dvgIncidencias
            // 
            this.dvgIncidencias.AllowUserToAddRows = false;
            this.dvgIncidencias.AllowUserToDeleteRows = false;
            this.dvgIncidencias.AllowUserToResizeColumns = false;
            this.dvgIncidencias.AllowUserToResizeRows = false;
            this.dvgIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Creador,
            this.Responsable,
            this.Tipo_de_incidencia,
            this.Estado_de_la_incidencia,
            this.Fecha_de_creación,
            this.Fecha_de_cierre});
            this.dvgIncidencias.Location = new System.Drawing.Point(12, 83);
            this.dvgIncidencias.Name = "dvgIncidencias";
            this.dvgIncidencias.ReadOnly = true;
            this.dvgIncidencias.Size = new System.Drawing.Size(936, 403);
            this.dvgIncidencias.TabIndex = 10;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Creador
            // 
            this.Creador.HeaderText = "Creador";
            this.Creador.Name = "Creador";
            this.Creador.ReadOnly = true;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            // 
            // Tipo_de_incidencia
            // 
            this.Tipo_de_incidencia.HeaderText = "Tipo_de_incidencia";
            this.Tipo_de_incidencia.Name = "Tipo_de_incidencia";
            this.Tipo_de_incidencia.ReadOnly = true;
            // 
            // Estado_de_la_incidencia
            // 
            this.Estado_de_la_incidencia.HeaderText = "Estado_de_la_incidencia";
            this.Estado_de_la_incidencia.Name = "Estado_de_la_incidencia";
            this.Estado_de_la_incidencia.ReadOnly = true;
            // 
            // Fecha_de_creación
            // 
            this.Fecha_de_creación.HeaderText = "Fecha_de_creación";
            this.Fecha_de_creación.Name = "Fecha_de_creación";
            this.Fecha_de_creación.ReadOnly = true;
            // 
            // Fecha_de_cierre
            // 
            this.Fecha_de_cierre.HeaderText = "Fecha_de_cierre";
            this.Fecha_de_cierre.Name = "Fecha_de_cierre";
            this.Fecha_de_cierre.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(24, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(24, 509);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(281, 509);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(145, 23);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(793, 509);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(145, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(632, 12);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(145, 23);
            this.btnInformes.TabIndex = 18;
            this.btnInformes.Text = "INFORMES";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(803, 45);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(145, 23);
            this.btnInformacion.TabIndex = 19;
            this.btnInformacion.Text = "INFORMACION";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(803, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(145, 23);
            this.btnAyuda.TabIndex = 20;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnMisIncidencias
            // 
            this.btnMisIncidencias.Location = new System.Drawing.Point(530, 509);
            this.btnMisIncidencias.Name = "btnMisIncidencias";
            this.btnMisIncidencias.Size = new System.Drawing.Size(164, 23);
            this.btnMisIncidencias.TabIndex = 21;
            this.btnMisIncidencias.Text = "MODO ADMINISTRADOR";
            this.btnMisIncidencias.UseVisualStyleBackColor = true;
            this.btnMisIncidencias.Click += new System.EventHandler(this.btnMisIncidencias_Click);
            // 
            // btnComentar
            // 
            this.btnComentar.Location = new System.Drawing.Point(632, 45);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(145, 23);
            this.btnComentar.TabIndex = 22;
            this.btnComentar.Text = "COMENTAR";
            this.btnComentar.UseVisualStyleBackColor = true;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // cbbSubtipo
            // 
            this.cbbSubtipo.FormattingEnabled = true;
            this.cbbSubtipo.Location = new System.Drawing.Point(372, 41);
            this.cbbSubtipo.Name = "cbbSubtipo";
            this.cbbSubtipo.Size = new System.Drawing.Size(121, 21);
            this.cbbSubtipo.TabIndex = 23;
            this.cbbSubtipo.SelectedIndexChanged += new System.EventHandler(this.cambioFiltrado);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "SUBTIPO";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbSubtipo);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.btnMisIncidencias);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dvgIncidencias);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgIncidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.DataGridView dvgIncidencias;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnMisIncidencias;
        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.ComboBox cbbSubtipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_de_la_incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_creación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_cierre;
    }
}
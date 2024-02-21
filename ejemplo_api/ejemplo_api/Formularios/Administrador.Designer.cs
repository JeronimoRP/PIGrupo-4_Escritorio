
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
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_creación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMisIncidencias = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(167, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ESTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(426, 44);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(79, 20);
            this.dtp1.TabIndex = 5;
            this.dtp1.Value = new System.DateTime(2024, 2, 20, 0, 0, 0, 0);
            this.dtp1.ValueChanged += new System.EventHandler(this.cambioFiltrado);
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(129, 44);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbbTipo.TabIndex = 7;
            this.cbbTipo.SelectedIndexChanged += new System.EventHandler(this.cambioFiltrado);
            this.cbbTipo.SelectedValueChanged += new System.EventHandler(this.cbbTipo_SelectedValueChanged);
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(269, 43);
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
            this.dvgIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Creador,
            this.Responsable,
            this.Tipo_de_incidencia,
            this.Estado,
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
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
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
            this.btnCrear.Location = new System.Drawing.Point(208, 509);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(803, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "MENSAJES";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "INFORMES";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(803, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "INFORMACION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(632, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "AYUDA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMisIncidencias
            // 
            this.btnMisIncidencias.Location = new System.Drawing.Point(610, 509);
            this.btnMisIncidencias.Name = "btnMisIncidencias";
            this.btnMisIncidencias.Size = new System.Drawing.Size(145, 23);
            this.btnMisIncidencias.TabIndex = 21;
            this.btnMisIncidencias.Text = "MIS INCIDENCIAS";
            this.btnMisIncidencias.UseVisualStyleBackColor = true;
            this.btnMisIncidencias.Click += new System.EventHandler(this.btnMisIncidencias_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(412, 509);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "COMENTAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 554);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnMisIncidencias);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_creación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_cierre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMisIncidencias;
        private System.Windows.Forms.Button button5;
    }
}
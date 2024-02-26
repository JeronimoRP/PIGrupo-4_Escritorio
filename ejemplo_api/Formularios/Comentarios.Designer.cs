
namespace ejemplo_api.Formularios
{
    partial class Comentarios
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
            this.dgvListaDeComentarios = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncidenciaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeComentarios
            // 
            this.dgvListaDeComentarios.AllowUserToAddRows = false;
            this.dgvListaDeComentarios.AllowUserToDeleteRows = false;
            this.dgvListaDeComentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaDeComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeComentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Fecha_de_creacion,
            this.IncidenciaID,
            this.Texto});
            this.dgvListaDeComentarios.Location = new System.Drawing.Point(12, 12);
            this.dgvListaDeComentarios.Name = "dgvListaDeComentarios";
            this.dgvListaDeComentarios.ReadOnly = true;
            this.dgvListaDeComentarios.Size = new System.Drawing.Size(474, 362);
            this.dgvListaDeComentarios.TabIndex = 0;
            this.dgvListaDeComentarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvListaDeComentarios_CellClick);
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // Fecha_de_creacion
            // 
            this.Fecha_de_creacion.HeaderText = "Fecha_de_creacion";
            this.Fecha_de_creacion.Name = "Fecha_de_creacion";
            this.Fecha_de_creacion.ReadOnly = true;
            // 
            // IncidenciaID
            // 
            this.IncidenciaID.HeaderText = "IncidenciaID";
            this.IncidenciaID.Name = "IncidenciaID";
            this.IncidenciaID.ReadOnly = true;
            // 
            // Texto
            // 
            this.Texto.HeaderText = "Texto";
            this.Texto.Name = "Texto";
            this.Texto.ReadOnly = true;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(518, 12);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(270, 414);
            this.txtTexto.TabIndex = 2;
            // 
            // btnModo
            // 
            this.btnModo.Location = new System.Drawing.Point(12, 380);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(236, 46);
            this.btnModo.TabIndex = 3;
            this.btnModo.Text = "MODO LECTURA";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(254, 380);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(232, 46);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Comentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnModo);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.dgvListaDeComentarios);
            this.Name = "Comentarios";
            this.Text = "Comentarios";
            this.Load += new System.EventHandler(this.Comentarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeComentarios;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncidenciaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texto;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Button btnEnviar;
    }
}
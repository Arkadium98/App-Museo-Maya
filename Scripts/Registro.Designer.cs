namespace AppSalaMaya.Scripts
{
    partial class Registro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultadoLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nawal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntajeMaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satisfacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoEnviado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Correo,
            this.Nacimiento,
            this.ResultadoLinea,
            this.Nawal,
            this.PuntajeMaya,
            this.Dios,
            this.Satisfacion,
            this.CorreoEnviado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(880, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Guardar cambios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 41;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Nacimiento
            // 
            this.Nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            this.Nacimiento.Width = 85;
            // 
            // ResultadoLinea
            // 
            this.ResultadoLinea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ResultadoLinea.HeaderText = "Linea del Tiempo";
            this.ResultadoLinea.Name = "ResultadoLinea";
            this.ResultadoLinea.ReadOnly = true;
            this.ResultadoLinea.Width = 104;
            // 
            // Nawal
            // 
            this.Nawal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nawal.HeaderText = "Nawal";
            this.Nawal.Name = "Nawal";
            this.Nawal.ReadOnly = true;
            this.Nawal.Width = 62;
            // 
            // PuntajeMaya
            // 
            this.PuntajeMaya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PuntajeMaya.HeaderText = "¿Es Maya?";
            this.PuntajeMaya.Name = "PuntajeMaya";
            this.PuntajeMaya.ReadOnly = true;
            this.PuntajeMaya.Width = 78;
            // 
            // Dios
            // 
            this.Dios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dios.HeaderText = "Dios";
            this.Dios.Name = "Dios";
            this.Dios.ReadOnly = true;
            this.Dios.Width = 53;
            // 
            // Satisfacion
            // 
            this.Satisfacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Satisfacion.HeaderText = "Satisfación";
            this.Satisfacion.Name = "Satisfacion";
            this.Satisfacion.ReadOnly = true;
            this.Satisfacion.Width = 84;
            // 
            // CorreoEnviado
            // 
            this.CorreoEnviado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CorreoEnviado.HeaderText = "CorreoEnviado";
            this.CorreoEnviado.Name = "CorreoEnviado";
            this.CorreoEnviado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CorreoEnviado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CorreoEnviado.Width = 102;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultadoLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nawal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntajeMaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satisfacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CorreoEnviado;
    }
}
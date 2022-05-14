namespace AppSalaMaya.Scripts
{
    partial class MessageBoxDios
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.pbDios = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.rbViajero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Gold;
            this.lbName.Location = new System.Drawing.Point(264, 51);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(137, 39);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "lbName";
            // 
            // lbDesc
            // 
            this.lbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.ForeColor = System.Drawing.SystemColors.Info;
            this.lbDesc.Location = new System.Drawing.Point(267, 98);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(256, 250);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "lbDesc";
            // 
            // pbDios
            // 
            this.pbDios.Location = new System.Drawing.Point(12, 51);
            this.pbDios.Name = "pbDios";
            this.pbDios.Size = new System.Drawing.Size(245, 297);
            this.pbDios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDios.TabIndex = 0;
            this.pbDios.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Location = new System.Drawing.Point(187, 368);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(140, 35);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = " ⮌ Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // rbViajero
            // 
            this.rbViajero.AutoSize = true;
            this.rbViajero.BackColor = System.Drawing.Color.Transparent;
            this.rbViajero.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbViajero.ForeColor = System.Drawing.Color.Gold;
            this.rbViajero.Location = new System.Drawing.Point(12, 9);
            this.rbViajero.Name = "rbViajero";
            this.rbViajero.Size = new System.Drawing.Size(111, 39);
            this.rbViajero.TabIndex = 23;
            this.rbViajero.Text = "Eres:";
            // 
            // MessageBoxDios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(536, 415);
            this.Controls.Add(this.rbViajero);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbDios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "MessageBoxDios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxDios";
            this.Load += new System.EventHandler(this.MessageBoxDios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbDios;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label rbViajero;
    }
}
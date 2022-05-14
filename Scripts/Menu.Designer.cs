namespace AppSalaMaya.Scripts
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostrarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarRegistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCodices = new System.Windows.Forms.Button();
            this.btnEstelas = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaya = new System.Windows.Forms.Button();
            this.btnDios = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarRegistroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostrarRegistroToolStripMenuItem
            // 
            this.mostrarRegistroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarRegistroToolStripMenuItem1,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mostrarRegistroToolStripMenuItem.Name = "mostrarRegistroToolStripMenuItem";
            this.mostrarRegistroToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mostrarRegistroToolStripMenuItem.Text = "Opciones";
            // 
            // mostrarRegistroToolStripMenuItem1
            // 
            this.mostrarRegistroToolStripMenuItem1.Name = "mostrarRegistroToolStripMenuItem1";
            this.mostrarRegistroToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.mostrarRegistroToolStripMenuItem1.Tag = "0";
            this.mostrarRegistroToolStripMenuItem1.Text = "Mostrar registro";
            this.mostrarRegistroToolStripMenuItem1.Click += new System.EventHandler(this.AccionAdministrador);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cerrarSesiónToolStripMenuItem.Tag = "1";
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.AccionAdministrador);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem.Tag = "2";
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.AccionAdministrador);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1242, 764);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnLinea, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCodices, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEstelas, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1236, 376);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnLinea
            // 
            this.btnLinea.BackColor = System.Drawing.Color.Transparent;
            this.btnLinea.BackgroundImage = global::AppSalaMaya.Properties.Resources.btnGlifos;
            this.btnLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLinea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLinea.FlatAppearance.BorderSize = 0;
            this.btnLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea.Location = new System.Drawing.Point(50, 50);
            this.btnLinea.Margin = new System.Windows.Forms.Padding(50);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(312, 276);
            this.btnLinea.TabIndex = 0;
            this.btnLinea.Tag = "0";
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnAbrirForm);
            // 
            // btnCodices
            // 
            this.btnCodices.BackgroundImage = global::AppSalaMaya.Properties.Resources.btnLinea;
            this.btnCodices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCodices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCodices.FlatAppearance.BorderSize = 0;
            this.btnCodices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnCodices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodices.Location = new System.Drawing.Point(462, 50);
            this.btnCodices.Margin = new System.Windows.Forms.Padding(50);
            this.btnCodices.Name = "btnCodices";
            this.btnCodices.Size = new System.Drawing.Size(312, 276);
            this.btnCodices.TabIndex = 1;
            this.btnCodices.Tag = "1";
            this.btnCodices.UseVisualStyleBackColor = true;
            this.btnCodices.Click += new System.EventHandler(this.btnAbrirForm);
            // 
            // btnEstelas
            // 
            this.btnEstelas.BackgroundImage = global::AppSalaMaya.Properties.Resources.btnDioses;
            this.btnEstelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEstelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstelas.FlatAppearance.BorderSize = 0;
            this.btnEstelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEstelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstelas.Location = new System.Drawing.Point(874, 50);
            this.btnEstelas.Margin = new System.Windows.Forms.Padding(50);
            this.btnEstelas.Name = "btnEstelas";
            this.btnEstelas.Size = new System.Drawing.Size(312, 276);
            this.btnEstelas.TabIndex = 2;
            this.btnEstelas.Tag = "2";
            this.btnEstelas.UseVisualStyleBackColor = true;
            this.btnEstelas.Click += new System.EventHandler(this.btnAbrirForm);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnMaya, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDios, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 385);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1236, 376);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnMaya
            // 
            this.btnMaya.BackgroundImage = global::AppSalaMaya.Properties.Resources.btnPiezas1;
            this.btnMaya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaya.FlatAppearance.BorderSize = 0;
            this.btnMaya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaya.Location = new System.Drawing.Point(50, 50);
            this.btnMaya.Margin = new System.Windows.Forms.Padding(50);
            this.btnMaya.Name = "btnMaya";
            this.btnMaya.Size = new System.Drawing.Size(518, 276);
            this.btnMaya.TabIndex = 3;
            this.btnMaya.Tag = "3";
            this.btnMaya.UseVisualStyleBackColor = true;
            this.btnMaya.Click += new System.EventHandler(this.btnAbrirForm);
            // 
            // btnDios
            // 
            this.btnDios.BackgroundImage = global::AppSalaMaya.Properties.Resources.arroba;
            this.btnDios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDios.FlatAppearance.BorderSize = 0;
            this.btnDios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDios.Location = new System.Drawing.Point(668, 50);
            this.btnDios.Margin = new System.Windows.Forms.Padding(50);
            this.btnDios.Name = "btnDios";
            this.btnDios.Size = new System.Drawing.Size(518, 276);
            this.btnDios.TabIndex = 4;
            this.btnDios.Tag = "4";
            this.btnDios.UseVisualStyleBackColor = true;
            this.btnDios.Click += new System.EventHandler(this.btnAbrirForm);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1242, 788);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnDios;
        private System.Windows.Forms.Button btnMaya;
        private System.Windows.Forms.Button btnEstelas;
        private System.Windows.Forms.Button btnCodices;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.ToolStripMenuItem mostrarRegistroToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem mostrarRegistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}
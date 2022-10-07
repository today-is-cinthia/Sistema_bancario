namespace banco
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbbanco = new System.Windows.Forms.Label();
            this.imagen = new CustomControls.Estudiantes.EduButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosBancariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbbanco
            // 
            this.lbbanco.AutoSize = true;
            this.lbbanco.BackColor = System.Drawing.Color.White;
            this.lbbanco.Font = new System.Drawing.Font("Gadugi", 19F, System.Drawing.FontStyle.Bold);
            this.lbbanco.ForeColor = System.Drawing.Color.Red;
            this.lbbanco.Location = new System.Drawing.Point(313, 232);
            this.lbbanco.Name = "lbbanco";
            this.lbbanco.Size = new System.Drawing.Size(113, 31);
            this.lbbanco.TabIndex = 1;
            this.lbbanco.Text = "BANCO ";
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.Transparent;
            this.imagen.BackgroundColor = System.Drawing.Color.Transparent;
            this.imagen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.imagen.BorderRadius = 0;
            this.imagen.BorderSize = 0;
            this.imagen.FlatAppearance.BorderSize = 0;
            this.imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagen.ForeColor = System.Drawing.Color.Turquoise;
            this.imagen.Image = global::banco.Properties.Resources.bank_solid_96__1_;
            this.imagen.Location = new System.Drawing.Point(318, 98);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(108, 112);
            this.imagen.TabIndex = 0;
            this.imagen.TextColor = System.Drawing.Color.Turquoise;
            this.imagen.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.serviciosBancariosToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cajaToolStripMenuItem.Text = "Caja";
            this.cajaToolStripMenuItem.Click += new System.EventHandler(this.cajaToolStripMenuItem_Click);
            // 
            // serviciosBancariosToolStripMenuItem
            // 
            this.serviciosBancariosToolStripMenuItem.Name = "serviciosBancariosToolStripMenuItem";
            this.serviciosBancariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviciosBancariosToolStripMenuItem.Text = "Servicios bancarios";
            this.serviciosBancariosToolStripMenuItem.Click += new System.EventHandler(this.serviciosBancariosToolStripMenuItem_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(819, 496);
            this.Controls.Add(this.lbbanco);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Estudiantes.EduButton imagen;
        private System.Windows.Forms.Label lbbanco;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosBancariosToolStripMenuItem;
    }
}


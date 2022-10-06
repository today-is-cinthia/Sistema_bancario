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
            this.label1 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.eduButton1 = new CustomControls.Estudiantes.EduButton();
            this.imagen = new CustomControls.Estudiantes.EduButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 19F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(120, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BANCO ";
            // 
            // cbRol
            // 
            this.cbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.cbRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRol.ForeColor = System.Drawing.SystemColors.Info;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(78, 200);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(189, 21);
            this.cbRol.TabIndex = 2;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // eduButton1
            // 
            this.eduButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.eduButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.eduButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.eduButton1.BorderRadius = 10;
            this.eduButton1.BorderSize = 0;
            this.eduButton1.FlatAppearance.BorderSize = 0;
            this.eduButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eduButton1.ForeColor = System.Drawing.Color.White;
            this.eduButton1.Location = new System.Drawing.Point(109, 278);
            this.eduButton1.Name = "eduButton1";
            this.eduButton1.Size = new System.Drawing.Size(126, 36);
            this.eduButton1.TabIndex = 3;
            this.eduButton1.Text = "INGRESAR";
            this.eduButton1.TextColor = System.Drawing.Color.White;
            this.eduButton1.UseVisualStyleBackColor = false;
            this.eduButton1.Click += new System.EventHandler(this.eduButton1_Click);
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
            this.imagen.Location = new System.Drawing.Point(118, 35);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(108, 112);
            this.imagen.TabIndex = 0;
            this.imagen.TextColor = System.Drawing.Color.Turquoise;
            this.imagen.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(356, 479);
            this.Controls.Add(this.eduButton1);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Estudiantes.EduButton imagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRol;
        private CustomControls.Estudiantes.EduButton eduButton1;
    }
}


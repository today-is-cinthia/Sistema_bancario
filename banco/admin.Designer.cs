namespace banco
{
    partial class SB
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new CustomControls.Estudiantes.EduButton();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cservicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtendido = new CustomControls.Estudiantes.EduButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lbHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BorderRadius = 0;
            this.btnRegresar.BorderSize = 0;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = global::banco.Properties.Resources.chevron_left_regular_36;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(44, 36);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.TextColor = System.Drawing.Color.White;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(699, 9);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(51, 20);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cnombre,
            this.Cservicio});
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.Cornsilk;
            this.grid.Location = new System.Drawing.Point(23, 79);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(372, 185);
            this.grid.TabIndex = 7;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            // 
            // Cservicio
            // 
            this.Cservicio.HeaderText = "Servicio";
            this.Cservicio.Name = "Cservicio";
            // 
            // btnAtendido
            // 
            this.btnAtendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnAtendido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnAtendido.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAtendido.BorderRadius = 10;
            this.btnAtendido.BorderSize = 0;
            this.btnAtendido.FlatAppearance.BorderSize = 0;
            this.btnAtendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtendido.ForeColor = System.Drawing.Color.White;
            this.btnAtendido.Location = new System.Drawing.Point(560, 364);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(217, 51);
            this.btnAtendido.TabIndex = 10;
            this.btnAtendido.Text = "ATENDER";
            this.btnAtendido.TextColor = System.Drawing.Color.White;
            this.btnAtendido.UseVisualStyleBackColor = false;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click);
            // 
            // SB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtendido);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "SB";
            this.Text = "SERVICIOS BANCARIOS";
            this.Load += new System.EventHandler(this.SB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHora;
        private CustomControls.Estudiantes.EduButton btnRegresar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cservicio;
        private CustomControls.Estudiantes.EduButton btnAtendido;
    }
}
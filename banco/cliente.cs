using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        void agregar(string servicio)
        {
            Banco.Encolar(txtNombre.Text, servicio);
            grid.Rows.Clear();
            grid2.Rows.Clear();
            foreach (var item in Banco.nombres)
            {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(grid);
                    filas.Cells[0].Value = item;
                    grid.Rows.Add(filas);
            }
            foreach (var item in Banco.sevicios)
            {
                DataGridViewRow filas = new DataGridViewRow();
                filas.CreateCells(grid2);
                filas.Cells[0].Value = item;
                grid2.Rows.Add(filas);
            }
            txtNombre.Clear();
            txtNombre.Focus();

        }
        private void cliente_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_FontChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }


        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login formulario = new login();
            formulario.Show();

            this.Hide();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            agregar("Caja");
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            agregar("Servicio Bancario");
        }

        private void eduButton1_Click(object sender, EventArgs e)
        {
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

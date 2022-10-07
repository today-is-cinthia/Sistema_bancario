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
    public partial class SB : Form
    {
        public SB()
        {
            InitializeComponent();
        }
 

        public string colabanco;

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void SB_Load(object sender, EventArgs e)
        {
        }

        private void btnAtendido_Click(object sender, EventArgs e)
        {
            if(grid.Rows[0].Cells[0].Value == "")
            {
                atencion.Text = "Sala de atención vacía";
            }
            else
            {
                atencion.Text = Banco.nombres[0] + " está siendo atendido";
                Banco.Desencolarnom();
                Banco.Desencolarser();
            }
            LLenarClientes();

        }

        private void eduButton1_Click(object sender, EventArgs e)
        {

        }

        public void LLenarClientes()
        {
            grid.Rows.Clear();
            grid2.Rows.Clear();
            foreach(var item in Banco.nombres)
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
        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

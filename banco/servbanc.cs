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
    public partial class servbanc : Form
    {
        public servbanc()
        {
            InitializeComponent();
        }
        public void LLenarClientes()
        {
            int n = 0;
            grid.Rows.Clear();
            grid2.Rows.Clear();
            /*foreach (var item in Banco.nombres)
            {
                DataGridViewRow filas = new DataGridViewRow();
                filas.CreateCells(grid);
                filas.Cells[0].Value = item;
                grid.Rows.Add(filas);
            }*/
            foreach (var item in Banco.sevicios)
            {
                if (item == "Servicio Bancario")
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(grid2);
                    filas.Cells[0].Value = item;
                    grid2.Rows.Add(filas);
                }
                if (item == "Servicio Bancario")
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(grid);
                    filas.Cells[0].Value = Banco.nombres[n];
                    grid.Rows.Add(filas);
                    if (grid.Rows[0].Cells[0].Value == "")
                    {
                        atencion.Text = "Sala de atención vacía";
                    }
                    else
                    {
                        atencion.Text = grid.Rows[0].Cells[0].Value + " es el siguiente en ser atendido";
                    }
                }
                n++;
            }
        }
        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

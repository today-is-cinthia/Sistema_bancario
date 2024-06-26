﻿using System;
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
    public partial class caja : Form
    {
        public caja()
        {
            InitializeComponent();
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

        private void eduButton1_Click(object sender, EventArgs e)
        {

        }

        private void caja_Load(object sender, EventArgs e)
        {

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
                if(item == "Caja")
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(grid2);
                    filas.Cells[0].Value = item;
                    grid2.Rows.Add(filas);
                }
                if (item == "Caja")
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

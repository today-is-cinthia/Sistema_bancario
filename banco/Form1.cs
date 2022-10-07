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
    public partial class login : Form
    {
        cliente formulario = new cliente();
        SB formulario2 = new SB();
        caja formulario3 = new caja();
        servbanc form4 = new servbanc();
        public login()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eduButton1_Click(object sender, EventArgs e)
        {
    
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario.MdiParent = this;
            formulario.Show();
            formulario2.Hide();
            formulario3.Hide();
            form4.Hide();
            imagen.Hide();
            lbbanco.Hide();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario2.MdiParent = this;
            formulario2.Show();
            formulario2.LLenarClientes();
            formulario.Hide();
            form4.Hide();
            formulario3.Hide();
            imagen.Hide();
            lbbanco.Hide();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario3.MdiParent = this;
            formulario3.Show();
            formulario3.LLenarClientes();
            formulario2.Hide();
            form4.Hide();
            formulario.Hide();
            imagen.Hide();
            lbbanco.Hide();
        }

        private void serviciosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form4.MdiParent = this;
            form4.Show();
            form4.LLenarClientes();
            formulario2.Hide();
            formulario.Hide();
            formulario3.Hide();
            imagen.Hide();
            lbbanco.Hide();
        }
    }
}

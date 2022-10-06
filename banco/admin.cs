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

        }
    }
}

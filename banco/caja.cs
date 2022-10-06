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
    }
}

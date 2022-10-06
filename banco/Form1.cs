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
        public login()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;


            cbRol.Items.Add("Cliente");
            cbRol.Items.Add("SB");
            cbRol.Items.Add("CAJA");

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eduButton1_Click(object sender, EventArgs e)
        {
            if(cbRol.Text == "Cliente")
            {
                cliente formulario = new cliente();
                formulario.Show();

                this.Hide();
            }
            if(cbRol.Text == "SB")
            {
                SB formulario2 = new SB();
                formulario2.Show();
                this.Hide();

            }
            if (cbRol.Text == "CAJA")
            {
                caja formulario3 = new caja();
                formulario3.Show();
                this.Hide();

            }
        }
    }
}

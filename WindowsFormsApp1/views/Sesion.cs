using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.views;

namespace WindowsFormsApp1
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text)) {
                this.lblErrorIngreso.Text = "Verifica los datos";
            }
            else
            {
                this.Hide();
                views.Menu menu = new views.Menu();
                menu.Show();
            }
 
        }

    }
}

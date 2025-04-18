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
using WindowsFormsApp1.views.login;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
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
            else if (this.textBox1.Text.Length < 5)
            {
                this.lblErrorIngreso.Text = "El usuario debe tener al menos 5 caracteres";
            }
            else if (this.textBox2.Text.Length < 8)
            {
                this.lblErrorIngreso.Text = "La contraseña debe tener al menos 8 caracteres";
            }
            else
            {
                this.Hide();
                Views.Gestor_menu menu = new Views.Gestor_menu();
                menu.Show();
            }
 
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            views.login.Register register = new views.login.Register();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

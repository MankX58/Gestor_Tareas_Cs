using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.views.login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtUsuario.Text) || string.IsNullOrEmpty(this.TxtPwd.Text) || string.IsNullOrEmpty(this.TxtConfirmPwd.Text))
            {
                this.lblErrorRegistro.Text = "Verifica los datos";
            }
            else if (this.TxtPwd.Text != this.TxtConfirmPwd.Text)
            {
                this.lblErrorRegistro.Text = "Las contraseñas no coinciden";
            }
            else if (this.TxtUsuario.Text.Length < 5)
            {
                this.lblErrorRegistro.Text = "El usuario debe tener al menos 5 caracteres";
            }
            else if (this.TxtPwd.Text.Length < 8)
            {
                this.lblErrorRegistro.Text = "La contraseña debe tener al menos 8 caracteres";
            }
            else
            {
                this.Hide();
                Views.Gestor_menu menu = new Views.Gestor_menu();
                menu.Show();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}

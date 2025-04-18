using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Views.tareas
{
    public partial class Ver_tareas : Form
    {
        public Ver_tareas()
        {
            InitializeComponent();
        }

        private void Ver_tareas_Load(object sender, EventArgs e)
        {
            dgvTareas.AutoGenerateColumns = true;
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = TareaStore.ListaTareas;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.Gestor_menu menu = new Views.Gestor_menu();
            menu.Show();
        }
    }
}

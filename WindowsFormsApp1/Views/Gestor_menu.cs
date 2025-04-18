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
using WindowsFormsApp1.views.tareas;
using WindowsFormsApp1.Views.tareas;

namespace WindowsFormsApp1.Views
{
    public partial class Gestor_menu : Form
    {
        public Gestor_menu()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            Agregar_tarea agregarTarea = new Agregar_tarea();
            agregarTarea.Show();
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            Ver_tareas verTareas = new Ver_tareas();
            verTareas.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

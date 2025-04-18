using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Views.tareas;

namespace WindowsFormsApp1.views.tareas
{
    public partial class Agregar_tarea : Form
    {
        private int contadorId = 1;
        public Agregar_tarea()
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
            Tarea nuevaTarea = new Tarea
            {
                Id = TareaStore.ContadorId++,
                Titulo = TxtTarea.Text,
                Descripcion = TxtDesc.Text,
                Categoria = TxtCategoria.Text,
                FechaLimite = dtpFechaLimite.Value
            };
            TareaStore.ListaTareas.Add(nuevaTarea);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TxtTarea.Clear();
            TxtDesc.Clear();
            TxtCategoria.Clear();
            dtpFechaLimite.Value = DateTime.Now;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_tarea_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ver_tareas ver_Tareas = new Ver_tareas();
            this.Hide();
            ver_Tareas.Show();
           
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

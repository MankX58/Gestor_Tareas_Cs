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

namespace WindowsFormsApp1.Views.tareas
{
    public partial class Borrar_tarea : Form
    {
        public Borrar_tarea()
        {
            InitializeComponent();
        }

        private void lblTitleborrartarea_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Borrar_tarea_Load(object sender, EventArgs e)
        {
            dgvTareas.AutoGenerateColumns = true;
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = TareaStore.ListaTareas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            int idAEliminar;

            if (int.TryParse(txtIDtarea.Text, out idAEliminar))
            {
                Tarea tareaAEliminar = TareaStore.ListaTareas.FirstOrDefault(t => t.Id == idAEliminar);

                if (tareaAEliminar != null)
                {
                    TareaStore.ListaTareas.Remove(tareaAEliminar);
                    MessageBox.Show("Tarea eliminada correctamente.");
                    ActualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se encontró una tarea con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void ActualizarTabla()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = TareaStore.ListaTareas;
        }
        private void txtIDtarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblTitlteBorrarTarea_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views.tareas
{
    internal class TareaStore
    {
        public static List<Tarea> ListaTareas { get; set; } = new List<Tarea>();
        public static int ContadorId { get; set; } = 1;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_creacion_clases
{
    public class Alumno : Persona
    {
        public string Carnet { get; }
        public DateTime FIngreso { get; }

        public Alumno (string nombre, string apellido, DateTime fnacimeiento, string telefono, string direccion, string carnet, DateTime fingreso)
            : base(nombre, apellido, fnacimeiento, telefono, direccion)
        {
            Carnet = carnet;
            FIngreso = fingreso;
        }
    }
}

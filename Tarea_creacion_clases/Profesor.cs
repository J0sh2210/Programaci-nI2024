using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_creacion_clases
{
    public class Profesor : Persona
    {
        public string Curso { get; }
        public string Departamento {  get; }
        public Profesor(string nombre, string apellido, DateTime fnacimeiento, string telefono, string direccion, string curso, string departamento)
        : base(nombre, apellido, fnacimeiento, telefono, direccion)
        {
            Curso = curso;
            Departamento = departamento;
        }
    }
    
}

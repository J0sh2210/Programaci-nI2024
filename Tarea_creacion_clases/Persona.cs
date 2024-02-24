using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_creacion_clases
{
    public class Persona
    {
        public string Nombre {  get; }
        public string Apellido { get; }
        public DateTime FNacimiento { get; }
        public string Telefono { get; }
        public string Direccion {  get; }

        public Persona(string nombre, string apellido, DateTime fnacimeiento, string telefono, string direccion) {
               if (nombre == null)
            
                Console.WriteLine( "nombre esta vacio");
            
               if (apellido == null)
            
                Console.WriteLine("apellido esta vacio");
            
               if (fnacimeiento == null)
            
                Console.WriteLine("la fecha de nacimiento esta vacio");
            
               if (telefono == null)
            
                Console.WriteLine("número de telefono esta vacio");
            
               if (direccion == null)
            
                Console.WriteLine("Direcci esta vacio");
            

            Nombre = nombre;
            Apellido = apellido;
            FNacimiento = fnacimeiento;
            Telefono = telefono;
            Direccion = direccion;

        }

    }
}

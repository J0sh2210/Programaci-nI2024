using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramación
{
    public class Usuario
    {
        public string Carnet {  get; set; }
        public string Nombre { get; set;}
        public string Telefono { get; set;}
        public string Grado { get; set; }
        public string User { get; set; }
        public Usuario() { }
        public Usuario(string Carnet, string Nombre, string Telefono, string Grado, string User)
        {
            this.Carnet = Carnet;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Grado = Grado;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6_desafios
{
    public class Superficie
    {
        public int Ancho {  get; set; }
        public int Alto {  get; set; }

        public void Ancho_largo(int ancho, int alto)
        {
            this.Ancho = ancho;
            this.Alto = alto;
        }



        public int SuperficieFrontal
        {
            get
            {
                return Ancho*Alto;
            }
        }
    }
}

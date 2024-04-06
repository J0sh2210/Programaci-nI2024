using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosesion7
{
    public class Calculadora_cientifica : Calculadora
    {
      
        public int Potencias { get; set; }
        public float Raiz { get; set; }
        public float Modulo {  get; set; }
        public float Logaritmo {  get; set; }

        public void Potencia ()
        {
            int Potencia = (int)Math.Pow(A, B);
            Console.WriteLine("La potencia es:" + Potencias);
        }

        public void RaizC()
        {
           int  Raizs = (int)Math.Sqrt(A);
            Console.WriteLine("La raíz cuadrada es: " + Raizs);

        }
        /*public void ModuloC()
        {
            double modul =  (double)A % (double)B;
            Console.WriteLine("El modulo es: " + modul);

        }*/
        public void LogaritmoC()
        {
                int Log = (int)Math.Log(A);
            Console.WriteLine("El logaritmo es: " + A);
        }



    }
}

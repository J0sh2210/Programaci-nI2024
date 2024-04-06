using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosesion7
{
    public class Calculadora
    {
        private string Marca {  get; set; }
        private string Serie { get; set; }
        public int Sumar { get; set; }
        public int Restar {  get; set; }
        public int Multiplicar { get; set; }
        public int Dividir { get; set; }
        protected int A {  get; set; }
        protected int B {  get; set; }

        public void Atributo (string marca, string serie)
        {
            this.Marca = marca;
            this.Serie = serie;
        }

        public void Numeros (int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public void suma()
        {
            int resultsuma = A + B;
            Console.WriteLine("La suma de los números es: " + resultsuma);
        }
        public void resta()
        {
            int resultsuma = A - B;
            Console.WriteLine("La suma de los números es: " + resultsuma);
        }
        public void multiplicacion ()
        {
            int resultsuma = A * B;
            Console.WriteLine("La suma de los números es: " + resultsuma);
        }
        public void division()
        {
            int resultsuma = A / B;
            Console.WriteLine("La suma de los números es: " + resultsuma);
        }
    }
}

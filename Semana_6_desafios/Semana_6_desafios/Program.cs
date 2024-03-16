using System;

namespace Semana_6_desafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número positivo");
            int numero = int.Parse(Console.ReadLine());
                if (numero < 0 ) {

                Console.WriteLine("Numero no válido");
                    }else
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        }
    }
}
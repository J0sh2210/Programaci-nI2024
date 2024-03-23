using System;

namespace sesion_7
{
    internal class Descuentos
    {
        static void Main(string[] args)
        {
            double[,] compras =  {
                {10, 500, 300, 20, 30, },
                {1000, 200, 40, 2, 3, },
                {2, 30, 5, 4, 1 },
                {40, 50, 50, 70, 40 },
                {500, 2300, 432, 322, 32 }

            };
            Aplicardescuento(compras);
        }

            static void Aplicardescuento(double[,] compras)
            {
                for (int clien = 0; clien < compras.GetLength(0); clien++) {
                    double compratotal = 0;
                    for (int compra = 0;  compra < compras.GetLength(1); compra++)
                    {
                        compratotal += compras[clien, compra];
                    }
                    double descuento = 0;
                    if (compratotal >= 100 && compratotal <= 1000) {
                        descuento = 0.1;
                    } else if (compratotal > 1000)
                    {
                        descuento = 0.2;
                    }
                    double total = compratotal - (compratotal * descuento);
                    Console.WriteLine($"El cliente número {clien + 1}");
                    Console.WriteLine($"La compra fue de: { compratotal}");
                    Console.WriteLine($"Descuento que se aplico: {(descuento * 100) : 0}%");
                    Console.WriteLine($"Total con descuento: {compratotal}");
                    Console.WriteLine();
                }
                
            } 

        
        
    }
}
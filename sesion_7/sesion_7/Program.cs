using System;
namespace sesion_7
{
    internal class Totito
    {
        static void Main(String[] args)
        {
            const int filas = 3;
            const int columnas = 3;
            string movimiento;
            String[,] tablero = new String[filas, columnas];
            void imprimir () {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        tablero[i, j] = "-";
                    }
                }
            }
            void consola_print ()
            {
                for(int i = 0;i < filas; i++)
                {
                    for(int j = 0; j < columnas;j++)
                    {
                        Console.Write(tablero[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            imprimir ();

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese su movimiento");
                    movimiento = Console.ReadLine();
                    tablero[i, j] = movimiento;
                    consola_print();
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(tablero[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

       

    }
}
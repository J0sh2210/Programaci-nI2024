using System;
namespace Primer_parcial_ejercicio_uno
{ 
    class Program
    {

        static void Main(string[] args)
        {
            String opcion = "";
            while (opcion != "4")
            {
                Console.WriteLine("Bienvenido al cajero automatico");
                Console.WriteLine("Escriba '1'  si quiere ver su saldo");
                Console.WriteLine("Escriba '2' si quiere depositar dinero");
                Console.WriteLine("Escriba '3' si quiere retirar dinero");
                Console.WriteLine("Escriba '4' si quiere salir del programa");
                opcion = Console.ReadLine();
                int dinero = 0;
                /* while (opcion >4)
                 {

                     if (opcion == 1)
                     {
                         Console.WriteLine("Escriba la cantidad a ingresar");
                         int cantidad = Console.Read();
                         dinero = dinero + cantidad;

                     }if (opcion == 2)
                     {
                         Console.WriteLine("ingrese cantidad a retirar");
                         int retirar = Console.Read();

                     }
                     if (opcion == 3)
                     {
                         Console.WriteLine("la cantidad de dinero que posee es: " + dinero);
                     }


                     } */
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("ingrese cantidad a depositar");
                        int deposito = Console.Read();
                        dinero = dinero + deposito;
                        break;
                    case "2":
                        Console.WriteLine("Ingrese cantidad a retirar");
                        int retiro = Console.Read();
                        dinero = dinero - retiro;
                        break;
                    case "3":
                        Console.WriteLine("Su saldo es " + dinero);
                        break;


                }
            }
            }



        }

    }


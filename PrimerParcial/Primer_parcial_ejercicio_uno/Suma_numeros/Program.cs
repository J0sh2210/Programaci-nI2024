using System;
namespace Suma_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int suma = Console.Read();
            int Num = 0;
           
            
                if (Num != 0)
                {
                    
                    Console.WriteLine("Ingrese un nuevo número");
                    suma = Console.Read();
                    Num = Num + suma;
                } else
                {
                    Console.WriteLine("La suma de los numeros es: " + Num);
                }
            
          
        }
    }
}

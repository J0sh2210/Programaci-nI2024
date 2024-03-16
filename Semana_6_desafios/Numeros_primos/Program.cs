namespace Semana_6_desafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número positivo");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(num + " no es primo");
                        break;
                    }
                    
                }
                if (num % num == 0){
                    Console.WriteLine(num + " es un número primo");
                }
            } else
            {
                Console.WriteLine("Debe ser un número positivo");
            }

            }
        }
    }

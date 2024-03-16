namespace Semana_6_desafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;
            float contador = 0;
            string fin;
            float nota_almacenada = 0 ;
            do
            {
                Console.WriteLine("Ingrese sus notas");
                nota = int.Parse(Console.ReadLine());
                contador++;
                nota_almacenada = nota_almacenada + nota;
                Console.WriteLine("Escriba 'FIN' si desea terminar de ingresar notas y 'NO' si quiere seguir escribiendo notas");
                fin = Console.ReadLine();
                if (fin == "FIN")
                {
                    Console.WriteLine("El promedio de las notas es: " + nota_almacenada/contador);
                    break;
                }if (fin == "NO")
                {
                    continue;
                }
            } while (nota >= 0 && nota <= 10);
        }
    }
}
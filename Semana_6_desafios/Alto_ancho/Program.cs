
namespace Semana_6_desafios {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el ancho y altura");
            Superficie superficie = new Superficie();
            superficie.Ancho_largo(20, 10);
            Console.WriteLine(superficie.SuperficieFrontal);
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
namespace Ejercico_uno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto junto con su correo electronico");
            string text = Console.ReadLine();
            string[] direc = Correo_ext(text);
            foreach (string direc2 in direc)
            {
                Console.WriteLine(direc2);
            }
        }
        static string[] Correo_ext (string text)
        {
            string pat = @"\b[A-Za-z0-9._-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
            Regex regex = new Regex(pat);
            MatchCollection coincide = regex.Matches(text);

            string[] correo = new string[coincide.Count];
            for (int i = 0; i < coincide.Count; i++)
            {
                correo[i] = coincide[i].Value;
            }

            return correo;
        }
    }


}

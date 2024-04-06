using desafiosesion7;

namespace desafiossesion7
{
    internal class Herencia
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Calculadora_cientifica cc =  new Calculadora_cientifica();
            calculadora.Atributo("Casio", "N300");
            calculadora.Numeros(30, 20);
            calculadora.suma();
            calculadora.resta();
            calculadora.multiplicacion();
            calculadora.division();
            cc.Potencia();
            cc.RaizC();
            //cc.ModuloC();
            cc.LogaritmoC();
        }
    }
}

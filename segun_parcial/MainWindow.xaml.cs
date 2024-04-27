using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Segundo_Parcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        public void Suma(object sender, EventArgs e)
        {

            Calculadora calculadora = new Calculadora{Num1 = "1", Num2= "3"};
            this.DataContext = calculadora;
        }
        public void Resta (object sender, EventArgs e)
        {

            Calculadora calculadora = new Calculadora { Num1 = "1", Num2 = "3" };
            this.DataContext = calculadora;
        }
        public void Multiplicacion (object sender, EventArgs e)
        {

            Calculadora calculadora = new Calculadora { Num1 = "1", Num2 = "3" };
            this.DataContext = calculadora;
        }
        public void Division (object sender, EventArgs e)
        {

            Calculadora calculadora = new Calculadora { Num1 = "1", Num2 = "3" };
            this.DataContext = calculadora;

        }
        public void Raiz (object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora { Num1 = "1" };
            this.DataContext = calculadora;
        }


    }
}
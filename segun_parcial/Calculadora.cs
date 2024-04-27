using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;

namespace Segundo_Parcial
{
    public class Calculadora : INotifyPropertyChanged
    {
        private string num1;
        private string num2  ;
        private string resultado;
        public string Num1
        {
            get
            {
                return num1;
            }
            set
            {
                if (decimal.TryParse(value, out var _))
                {
                    num1 = value;
                }
                OnPropertyChanged("num1");
                OnPropertyChanged("resultado");
            }
        }

        public string Num2
        {
            get
            {
                return num2;
            }
            set
            {
                if (decimal.TryParse(value, out var _))
                {
                    num2 = value;
                }
                OnPropertyChanged("num2");
                OnPropertyChanged("resultado");
            }
        }

        public string Sum
        {
            get
            {
                return (int.Parse(Num1) + int.Parse(Num2)).ToString();
            }
            set
            {
                resultado = (int.Parse(Num1) + int.Parse(Num2)).ToString();
                OnPropertyChanged("resultado");
            }
        }
        public string Rest
        {
            get
            {
                return (int.Parse(Num1) - int.Parse(Num2)).ToString();
            }
            set
            {
                resultado = (int.Parse(Num1) - int.Parse(Num2)).ToString();
                OnPropertyChanged("resultado");
            }
        }
        public string Mult
        {
            get
            {
                return (int.Parse(Num1) * int.Parse(Num2)).ToString();
            }
            set
            {
                resultado = (int.Parse(Num1) * int.Parse(Num2)).ToString();
                OnPropertyChanged("resultado");
            }
        }
        public string Div
        {
            get
            {
                return (int.Parse(Num1) / int.Parse(Num2)).ToString();
            }
            set
            {
                resultado = (int.Parse(Num1) / int.Parse(Num2)).ToString();
                OnPropertyChanged("resultado");
            }
        }

        public string Raiz_cuadradra
        {
            get
            {
                return(int.Parse(Num1.Sqrt).ToString;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propiedad)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
       /* private string num1;
        private string num2;
        private string resultado;
        public string Num1
        {
            get { return num1; }
            set
            {
                num1 = value;
               
            }

        }
        public string Num2
        {
            get
            {
                return num1;
            }
            set { num1 = value; }
        }
        public string Resultado
        {
            get
            {
                return (int.Parse(Num1) + int.Parse(Num2)).ToString();
            }
            set
            {
                resultado = (int.Parse(Num1) + int.Parse(Num2)).ToString();


            }

        } */

       

      
    }
}

    


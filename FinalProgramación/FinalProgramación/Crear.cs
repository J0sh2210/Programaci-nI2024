using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgramación
{
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Carnet = textBox_Carnet.Text;
            usuario.Nombre = textBox_Nom.Text;
            usuario.Telefono = textBox_Tel.Text;
            usuario.Grado = textBox_Grado.Text;
           
            int result = AlumnoDAL.AgregarPersona(usuario);
            if (result > 0)
            {
                MessageBox.Show("Exito al guardar");
              
                
                this.Close();
                Refresh();
            }
            else
            {
                MessageBox.Show("No se guardo");
            }

            

        }
    }
}

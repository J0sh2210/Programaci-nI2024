using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DBServices;
using DataAccess.DBServices.Entities;

namespace Presentation
{
    public partial class Agregar_callficaciones : Form
    {
        public int Carnet;
        public Agregar_callficaciones(/*int carnet*/)
        {
            InitializeComponent();
           // Carnet = carnet;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_callficaciones_Load(object sender, EventArgs e)
        {
            
        }

        private void boton_Confirmar_Click(object sender, EventArgs e)
        {
        /* Alumnos_registro alumnos_Registro = new Alumnos_registro();
        Alumno alumno = new Alumno();
            Alumnos_calificaciones alumnos_Calificaciones = new Alumnos_calificaciones();
            alumno = alumnos_Calificaciones.GetAlumnoByCarnet(Carnet);
            textCarnet.Text = alumno.Carnet;*/
        }
    }
}

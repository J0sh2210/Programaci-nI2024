using DataAccess;
using DataAccess.DBServices;
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

namespace Presentation
{
    public partial class Calificaciones : Form
    {
        public Calificaciones()
        {
            InitializeComponent();
        }



        private void Calificaciones_Load(object sender, EventArgs e)
        {
            

                DataTable dataTable = new DataTable();
                Alumnos_calificaciones alumnos_Calificaciones = new Alumnos_calificaciones();
                dataTable = alumnos_Calificaciones.GetAllCalificaciones();
                dataGridcali.DataSource = dataTable;
            
        }
        private void bton_agregar_Click(object sender, EventArgs e)
        {
            Agregar_callficaciones agregar_Callficaciones = new Agregar_callficaciones();
            agregar_Callficaciones.Show();
            this.Close();
        }
    }
}

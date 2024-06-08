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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = AlumnoDAL.PresentarGrid();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(dataGridView2.CurrentRow.Cells["Carnet"].Value);


            Usuario usuario = new Usuario();
                
                int result = AlumnoDAL.Modificar(usuario);
                if (result > 0)
                {
                    MessageBox.Show("Exito al Modificar");
                }
                else
                {
                    MessageBox.Show("No se modifico");
                }

            
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            textBox_carnet.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Carnet"].Value);
            textBox_Nom.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Nombre"].Value);
            textBox_Tel.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Telefono"].Value);
            textBox_grado.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["Grado"].Value);



        }
    }
}

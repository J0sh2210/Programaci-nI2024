namespace FinalProgramación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crear crear = new Crear();
            crear.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            Refresh();
            Focus();
        }
        private void Refresh()
        {
            dataGridView1.DataSource = AlumnoDAL.PresentarGrid();

        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar ();
            actualizar.Show();
        }
    }
}

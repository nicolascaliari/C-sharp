namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GestionUsuarios VentanaGestionUsuarios = new GestionUsuarios();
            VentanaGestionUsuarios.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }
    }
}
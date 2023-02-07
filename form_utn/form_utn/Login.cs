namespace form_utn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_usuario.Text;

            if (usuario == "nicolas" && this.txt_password.Text == "nico")
            {
                MenuPrincipal frm = new MenuPrincipal(usuario);

                frm.Show(); // Lo uso para que cuando haga click en el boton me envie al otro fotrmulario.

                this.Hide(); // Lo uso para que no me queden los dos formularios abiertos.
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_utn
{
    public partial class MenuPrincipal : Form
    {

        private string usuario;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(string usuario):this()
        {
            this.usuario = usuario;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

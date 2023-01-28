using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.dao;
using WinFormsApp1.modelos;

namespace WinFormsApp1
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
           InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            ClienteDao baseDeDatos = new ClienteDao();
            List<Usuario> lista = baseDeDatos.listadoDeUsuarios();
        
            listUsuarios.Items.Clear();
            for(int i = 0; i < lista.Count; i++)
            {
                Usuario usuario = lista[i];
                listUsuarios.Items.Add(usuario);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nombre = txt_nombre.Text;
            usuario.apellido = txt_apellido.Text;
            usuario.telefono = txt_telefono.Text;
            usuario.tarjetaDeCredito = txt_tarjeta.Text;

            if(label6.Text != "")
            {
                usuario.id = label6.Text;
            }

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(usuario);
            actualizarLista();
            limpiarLista();


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario) listUsuarios.SelectedItem;

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Eliminar(usuario);
            actualizarLista();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)listUsuarios.SelectedItem;
            txt_nombre.Text = usuario.nombre;
            txt_apellido.Text= usuario.apellido;
            txt_telefono.Text = usuario.telefono;
            txt_tarjeta.Text = usuario.tarjetaDeCredito;
            label6.Text = usuario.id;
        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {
            limpiarLista();
        }

        private void limpiarLista()
        {
            label6.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_telefono.Text = "";
            txt_tarjeta.Text = "";
        }
    }
}

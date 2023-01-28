using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.modelos;

namespace WinFormsApp1.dao
{
    internal class ClienteDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "Usuarios";

            string cadenaConexion = "Database=" + baseDeDatos + "; Data Source="
               + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            MySqlConnection conexionBd = new MySqlConnection(cadenaConexion);

            conexionBd.Open();

            return conexionBd;
        }

        public List<Usuario> listadoDeUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            string consulta = "SELECT * FROM `usuarios`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            string resultado = "";
            while (lectura.Read())
            {
                Usuario usuario = new Usuario();
                usuario.id = lectura.GetString("id");
                usuario.nombre = lectura.GetString("nombre");
                usuario.apellido = lectura.GetString("apellido");
                usuario.telefono = lectura.GetString("telefono");
              //  usuario.tarjetaDeCredito = lectura.GetString("tarjeta_de_credito");
                lista.Add(usuario);
            }
            comando.Connection.Close();

            return lista;
        }

        public void Guardar(Usuario usuario)
        {
            if(usuario.id == null)
            {
                Insert(usuario);
            }else
            {
                Update(usuario);
            }
           
        }

        private void Insert(Usuario usuario)
        {

            string consulta = "INSERT INTO `usuarios` (`id`, `nombre`, `apellido`, `telefono`, `tarjeta+de`) VALUES (NULL, '" + usuario.nombre + "', '" + usuario.apellido + "', '" + usuario.telefono + "', '" + usuario.tarjetaDeCredito + "');\r\n";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }


        private void Update(Usuario usuario)
        {

            string consulta = "UPDATE `usuarios` SET `nombre` = '"+ usuario.nombre +"', `apellido` = '"+ usuario.apellido +"', `telefono` = '"+ usuario.telefono +"', `tarjeta+de` = '"+ usuario.tarjetaDeCredito +"' WHERE `usuarios`.`id` = "+ usuario.id +";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }


        public void Eliminar(Usuario? usuario)
        { 
            string consulta = "DELETE FROM `usuarios` WHERE `usuarios`.`id` = "+ usuario.id +"";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}

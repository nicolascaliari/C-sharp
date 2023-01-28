using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public static class Sistema
    {

        static Usuario[] usuarioRegistrado;

        static Sistema()// constructor static Sistema
        {
            usuarioRegistrado = new Usuario[8];
            CargarUsuariosRegistrados();
        }

        private static void CargarUsuariosRegistrados()
        {
            usuarioRegistrado[0] = new Usuario("pepe", "lala");
            usuarioRegistrado[1] = new Usuario("pepe", "lala");
            usuarioRegistrado[2] = new Usuario("pepe", "lala");
            usuarioRegistrado[3] = new Usuario("pepe", "lala");
            usuarioRegistrado[4] = new Usuario("pepe", "lala");
        }

        public static bool ChekearUsuario(string nombre, string pass)
        {
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(pass))
            {
                return false;
            }

            for(int i = 0; i < usuarioRegistrado.Length; i++)
            {
                if (usuarioRegistrado[i] != null)
                {
                    if (nombre.Trim() == usuarioRegistrado[i].getNombre())
                    {
                        return usuarioRegistrado[i].CheekPass(pass);

                    }
                }

            }


            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Usuario
    {
        private string nombre;
        private string password;

        public Usuario(string nombre, string pass)
        { 
            this.nombre = nombre;
            this.password = pass;
        }

        public string getNombre()
        {
            return nombre;                   
        }

        public bool CheekPass(string pass)
        {
            return password == pass;
        }
    }
}

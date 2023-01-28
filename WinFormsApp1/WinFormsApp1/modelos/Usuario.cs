using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.modelos
{
    internal class Usuario
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string tarjetaDeCredito { get; set; }

        public string nombreCompleto
        {
            get
            {
                return nombre + " " + apellido;
            }
        }
        public override string ToString()
        {
            return nombreCompleto;
        }
    }
}

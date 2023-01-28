using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca

{
    public class Sumador
    {

        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;

        }

        public Sumador()
            :this(0)
        {
        }


        public int getCantidad()
        {
            return cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a , string b)
        {
            if(string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
            {
                return string.Empty;
            }

            if(string.IsNullOrEmpty(a))
            {
                return b;
            }

            if(string.IsNullOrEmpty(b))
            {
                return a;
            }

            return string.Empty;
        }
    }
}

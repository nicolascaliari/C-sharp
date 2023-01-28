using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestamo
{
    public class Cuenta
    {
        //creo los atributos de la clase
        private string titular;
        private decimal cantidad;

        //creo el constructor
        public Cuenta(string titular, decimal cantidad)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }

        //getters
        public string getTitular()
        {
            return this.titular;    
        }

        public decimal getCantidad()
        {
            return this.cantidad;
        }

        //metodos
        public string mostrar()
        {
            StringBuilder sb  = new StringBuilder();

            sb.AppendLine($"Titular: {getTitular()}");
            sb.AppendLine($"Cantidad{getCantidad()}");

            return sb.ToString();
        }

        public void ingresar(decimal montoCantidad)
        {
            if(cantidad > 0)
            {
                cantidad += montoCantidad;
            }

        }

        public void retirar(decimal montoRetirar)
        {
            cantidad -= montoRetirar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    // public --> Modificar de acceso
    // class --> Declara clases
    // Gato --> Nombre de la clase
    public class Gato
    {
        //atributos
        private string nombre;
        private string tipo_de_pelo;
        private double peso;
        private DateTime fecha_de_nacimiento;


        //Constructor
        public Gato(string nombre, string tipo_de_pelo, DateTime fecha_de_nacimiento)
        {
            setNombre(nombre);
            this.tipo_de_pelo = tipo_de_pelo;
            this.fecha_de_nacimiento = fecha_de_nacimiento;

        }

        public void setNombre(string nombre)
        {
            if(string.IsNullOrWhiteSpace(nombre))
            {
                nombre = "Sin nombre";
            }
            this.nombre = nombre;
        }


        //ahora defino un metodo

        public void AsignarPeso(double peso)
        {
            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return peso;
        }

        public string ObtenerDato()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del gato: ");
            sb.AppendLine($"Nombre del gato:{nombre}");
            sb.AppendLine($"Tipo de pelo: {tipo_de_pelo}");
            sb.AppendLine($"Peso : {peso}");
            sb.AppendLine($"Fecha de nacimiento : {fecha_de_nacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }
    }
}

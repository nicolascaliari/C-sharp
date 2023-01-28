using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_objetos1
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


        //Constructor
        public Gato(string nombre, string tipo_de_pelo)
        {
            this.nombre = nombre;
            this.tipo_de_pelo = tipo_de_pelo;
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
            sb.AppendFormat($"Nombre del gato:{nombre}");
            sb.Append($"Tipo de pelo: {tipo_de_pelo}");
            sb.AppendLine($"Peso : {peso}");

            return sb.ToString();
        }
    }
}

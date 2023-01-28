using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    //Sobrecarga en constructores
    public class Persona
    {
        private string nombre;
        private DateTime fecha_nacimiento;
        private long dni;

        public Persona(string nombre, DateTime fecha_nacimiento, long dni)
        {
            this.nombre = nombre;
            this.fecha_nacimiento = fecha_nacimiento;
            this.dni = dni;
        }

        public Persona()
        {
            this.nombre = string.Empty;
            this.fecha_nacimiento = new DateTime(1999, 1, 1);
            this.dni = dni;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{nombre}");
            sb.AppendLine($"Fecha:{fecha_nacimiento.ToString()}");
            sb.AppendLine($"Dni:{dni}");
            
            return sb.ToString();   
        }

    }
}

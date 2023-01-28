using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    public class SobreCarga
    {
        //Sobrecarga de metodos
        public static int Sumar(int operador_uno, int operador_dos)
        {
            return operador_dos + operador_uno;
        }

        public static int Sumar(int operador_uno, int operador_dos, int operador_tres)
        {
            return operador_dos + operador_uno + operador_tres;
        }


        public static float Sumar(float operador_dos, float operador_uno)
        {
          return operador_dos + operador_uno;
        }
    }
}

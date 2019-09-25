using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaSumar
{
    public class Datos
    {
        //Creación del metodo obtener datos
        public void ObtenerDatos()
        {
            //Se da la bienvenida al usuario y se le pide ingresar datos los cuales se almacenan en variables
            Console.WriteLine("Hola bienvenido");
            Console.WriteLine("Ingresa 2 datos");
            Console.WriteLine("Dato1");
            double cool = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dato2");
            double cool2 = Convert.ToDouble(Console.ReadLine());
            //Se instancia la clase operaciones
            Operaciones O = new Operaciones();
            double res = O.Sumar(cool, cool2);
            //Salida de resultado
            Console.WriteLine("Resultado " + res);
        }
    }
}

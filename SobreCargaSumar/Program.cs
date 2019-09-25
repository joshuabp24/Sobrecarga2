using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaSumar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase datos en el program.cs
            Datos d = new Datos();
            //Se manda a llamar a el metodo Obtener datos
            d.ObtenerDatos();
            Console.ReadKey();

        }
    }
}

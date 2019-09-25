using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaSumar
{
    public class Operaciones
    {
        //Creación de la sobrecarga de metodo
        public double Sumar(double a, double b)
        {
            return a + b;
        }
        public double Sumar(double a)
        {
            return a + 2;
        }
        public double Sumar()
        {
            return 2 + 1;
        }
    }
}

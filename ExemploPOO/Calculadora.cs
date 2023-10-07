using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Calculadora
    {
        public static int Somar(int x, int y)
        {
            Console.WriteLine("Somar int");
            return x + y;
        }

        public static double Somar(double x, double y)
        {
            Console.WriteLine("Somar double");
            return x + y;
        }
    }
}

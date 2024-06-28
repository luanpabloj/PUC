using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Cientifica : Calculadora
    {

        public static double Logaritmo(double x)
        {
            return Math.Log(x);
        }

        public static double LogaritmoBase10(double x)
        {
            return Math.Log10(x);
        }

        public static double Seno(double x)
        {
            return Math.Sin(x);
        }

        public static double Cosseno(double x)
        {
            return Math.Cos(x);
        }

        public static double Tangente(double x)
        {
            return Math.Tan(x);
        }
    }
}

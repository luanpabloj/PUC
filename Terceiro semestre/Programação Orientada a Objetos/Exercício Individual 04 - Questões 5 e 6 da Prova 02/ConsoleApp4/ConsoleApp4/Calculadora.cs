using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Calculadora
    {
        public static long Adicao(long x, long y)
        {
            return x + y;
        }

        public static long Subtracao(long x, long y)
        {
            return x - y;
        }

        public static long Multiplicacao(long x, long y)
        {
            return x * y;
        }

        public static long Divisao(long x, long y)
        {
            return x / y;
        }

        public static double Potencia(long x, long y)
        {
            return Math.Pow(x, y);
        }

        public static double RaizQuadrada(long x)
        {
            return Math.Sqrt(x);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Programador : Calculadora
    {
        public static string DecimalParaBinario(long x)
        {
            return Convert.ToString(x, 2);
        }

        public static string DecimalParaHexadecimal(long x)
        {
            return Convert.ToString(x, 16);
        }

        public static string DecimalParaOctal(long x)
        {
            return Convert.ToString(x, 8);
        }

        public static long BinarioParaDecimal(string bin)
        {
            return Convert.ToInt64(bin, 2);
        }

        public static long HexadecimalParaDecimal(string hex)
        {
            return Convert.ToInt64(hex, 16);
        }

        public static long OctalParaDecimal(string oct)
        {
            return Convert.ToInt64(oct, 8);
        }

        public static long And(long x, long y)
        {
            return x & y;
        }

        public static long Or(long x, long y)
        {
            return x | y;
        }

        public static long Xor(long x, long y)
        {
            return x ^ y;
        }

        public static long Not(long x)
        {
            return ~x;
        }

        public static long ShiftLeft(long x, int n)
        {
            return x << n;
        }

        public static long ShiftRight(long x, int n)
        {
            return x >> n;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Financeiro : Calculadora
    {
        public static double JurosSimples(double principal, double taxa, double tempo)
        {
            return principal * taxa * tempo;
        }

        public static double JurosCompostos(double principal, double taxa, double tempo)
        {
            return principal * Math.Pow((1 + taxa), tempo) - principal;
        }

        public static double PagamentoEmprestimo(double principal, double taxa, double numeroParcelas)
        {
            double taxaMensal = taxa / 12;
            return (principal * taxaMensal) / (1 - Math.Pow(1 + taxaMensal, -numeroParcelas));
        }

        public static double ValorFuturo(double principal, double taxa, double tempo)
        {
            return principal * Math.Pow((1 + taxa), tempo);
        }

        public static double ValorPresente(double valorFuturo, double taxa, double tempo)
        {
            return valorFuturo / Math.Pow((1 + taxa), tempo);
        }
    }
}

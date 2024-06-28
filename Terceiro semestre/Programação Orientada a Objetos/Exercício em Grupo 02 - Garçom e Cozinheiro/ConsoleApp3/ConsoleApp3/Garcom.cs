using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Garcom : Funcionario
    {
        private double comissao { get; set; }
        private double valorEmVendas { get; set; }
        public Garcom(double valorEmVendas, string name, double workedHours, double baseSalary, IRegime regime) : base(name, workedHours, baseSalary, regime)
        {
            this.valorEmVendas = valorEmVendas;
        }

        public double calcularComissao()
        {
            comissao = valorEmVendas * 0.10;
            return comissao;
        }

        public override double calcularSalario()
        {
            finalSalary = regime.finalSalary(baseSalary, workedHours) + calcularComissao();
            return finalSalary;
        }

        public override String toString()
        {
            return "\nId: " + id + "\nNome: " + name + "\nRegime: " + regime.getName() + "\nSalário base: " + baseSalary + "\nHoras trabalhadas: " + workedHours + "\nComissão: " + calcularComissao() + "\nValor em vendas: " + valorEmVendas + "\nSalário Final: " + calcularSalario() + "\n";

        }
    }
}

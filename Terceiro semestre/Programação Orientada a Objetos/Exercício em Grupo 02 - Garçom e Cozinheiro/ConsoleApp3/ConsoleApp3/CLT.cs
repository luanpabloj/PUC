using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CLT : IRegime
    {
        private string name = "CLT";

        public string getName()
        {
            return name;
        }
        public double finalSalary(double baseSalary, double workedHours)
        {
            return (baseSalary / 200) * workedHours;
        }
    }
}

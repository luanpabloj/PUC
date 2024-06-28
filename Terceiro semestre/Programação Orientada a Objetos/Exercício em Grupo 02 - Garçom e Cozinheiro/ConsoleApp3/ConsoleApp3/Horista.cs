using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Horista : IRegime
    {
        private string name = "Horista";
        public string getName()
        {
            return name;
        }
        public double finalSalary(double baseSalary, double workedHours)
        {
            return baseSalary * workedHours;
        }

    }
}

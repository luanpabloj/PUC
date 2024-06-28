using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FreeLancer : IRegime
    {
        private string name = "FreeLancer";
        public string getName()
        {
            return name;
        }
        public double finalSalary(double baseSalary, double workedDays)
        {
            return baseSalary * workedDays;
        }
    }
}

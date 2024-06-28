using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface IRegime
    {
        double finalSalary(double baseSalary, double workedHours);
        string getName();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Funcionario
    {
        protected long id;
        protected string name;
        protected double workedHours;
        protected double baseSalary;
        protected double finalSalary {  get; set; }
        protected IRegime regime;

        public static long geradordeId = 0;

        public Funcionario(string name, double workedHours, double baseSalary, IRegime regime)
        {
            this.id = geradordeId++;
            this.name = name;
            this.workedHours = workedHours;
            this.baseSalary = baseSalary;
            this.regime = regime;
        }

        public string getName()
        {
            return name;
        }
        public long getId()
        {
            return id;
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public double getWorkedHours()
        {
            return workedHours;
        }

        public void setWorkedHours(double workedHours)
        {
            this.workedHours = workedHours;
        }

        public double getBaseSalary()
        {
            return baseSalary;
        }

        public void setBaseSalary(double baseSalary)
        {
            this.baseSalary = baseSalary;
        }

        public IRegime getRegime()
        {
            return regime;
        }

        public void setRegime(IRegime regime)
        {
            this.regime = regime;
        }

        public virtual double calcularSalario()
        {
            finalSalary = regime.finalSalary(baseSalary, workedHours);
            return finalSalary;
        }

        public virtual String toString()
        {
            return "\nId: " + id + "\nNome: " + name + "\nRegime: " + regime.getName() + "\nSalário base: " + baseSalary + "\nHoras trabalhadas: " + workedHours + "\nSalário Final: " + calcularSalario() + "\n";

        }
    }
}

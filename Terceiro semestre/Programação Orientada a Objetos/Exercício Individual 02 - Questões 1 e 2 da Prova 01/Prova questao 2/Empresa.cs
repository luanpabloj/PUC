using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_questao_2
{
    internal class Empresa
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private double horasTotal;

        public Empresa(double horasTotal)
        {
            this.horasTotal = horasTotal;
        }

        public double getHorasTotal()
        {
            return this.horasTotal;
        }
        
        public void setHorasTotal(double horasTotal)
        {
            this.horasTotal = horasTotal;
        }

        public List<Funcionario> getFuncionarios()
        {
            return funcionarios;
        }

    }
}

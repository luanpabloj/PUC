using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_questao_2
{
    internal class Tarefa
    {
        private string nome;
        private double cargaHorario;
        private Funcionario funcionario;
        private double cargaTrabalhada;
        private string status;

        public Tarefa(string nome, double cargaHorario, Funcionario funcionario)
        {
            this.nome = nome;
            this.cargaHorario = cargaHorario;
            this.funcionario = funcionario;
            this.cargaTrabalhada = cargaTrabalhada;
            this.status = "pendente";

        }

        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public double getCargaHorario()
        {
            return cargaHorario;
        }
        public void setCargaHorario(double cargaHorario)
        {
            this.cargaHorario = cargaHorario;
        }
        public Funcionario getFuncionario()
        {
            return funcionario;
        }
        public double getCargaTrabalhada()
        {
            return cargaTrabalhada;
        }

        public void setCargaTrabalhada(double cargaTrabalhada)
        {
            this.cargaTrabalhada = cargaTrabalhada;
        }


        public void setFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }


        public bool addHoras(double horas) {
        
           if(cargaTrabalhada < cargaHorario){
                cargaTrabalhada += horas;
                return true;
           }
            else
            {
                status = "concluído";
                return false;
            }
        }

        public bool terminarTarefa()
        {
            if (cargaTrabalhada == cargaHorario){
                status = "concluído";
                cargaTrabalhada += cargaHorario;
                return true;
            }
            else
            {
                Console.WriteLine("Não foi possível concluir a tarefa, pois está faltando " + (cargaHorario - cargaTrabalhada) + " horas trabalhada para terminar a tarefa");
                return false;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Tarefa tarefa &&
                   nome == tarefa.nome &&
                   EqualityComparer<Funcionario>.Default.Equals(funcionario, tarefa.funcionario);
        }

        public string toString()
        {
            return nome + "\n";
        }
    }
}

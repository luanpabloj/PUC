using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_questao_2
{
    internal class Funcionario
    {
        private String nome;
        private String dataNascimento;
        private float cpf;
        private String cargo;
        private String departamento;
        private DateTime dataAdmissao;
        private List<Tarefa> tarefas = new List<Tarefa>(10);
        private int cargaMaxima = 200;
        private double horasTrabalhadas;

        public Funcionario(string nome, string dataNascimento, float cpf, string cargo, string departamento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.cargo = cargo;
            this.departamento = departamento;
            this.dataAdmissao = DateTime.Now;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getDataNascimento()
        {
            return dataNascimento;
        }

        public void setDataNascimento(String dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public float getCpf()
        {
            return cpf;
        }

        public void setCpf(float cpf)
        {
            this.cpf = cpf;
        }

        public String getCargo()
        {
            return cargo;
        }

        public void setCargo(String cargo)
        {
            this.cargo = cargo;
        }

        public String getDepartamento()
        {
            return departamento;
        }

        public void setDepartamento(String departamento)
        {
            this.departamento = departamento;
        }

        public DateTime getDataAdmissao()
        {
            return dataAdmissao;
        }

        public void setDataAdmissao(DateTime dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }

        public List<Tarefa> getTarefas()
        {
            return tarefas;
        }

        public void setTarefas(List<Tarefa> tarefas)
        {
            this.tarefas = tarefas;
        }

        public int getCargaMaxima()
        {
            return cargaMaxima;
        }


        public double getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }

        public void setHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public bool adicionarTarefa(Tarefa tarefa)
        {
            if (tarefas.Count() < 10)
            {
                tarefas.Add(tarefa);
                return true;
            }
            else
            {
                Console.WriteLine("Não foi possível adicionar a tarefa, pois a lista de tarefas do funcionário está cheio ou funcionario não encontrado");
                return false;
            }
        }

        public void addHorasTrabalhadasTarefa(double horasTrabalhadasnaTarefa, string nomeTarefa)
        {
            foreach(Tarefa ta in tarefas)
            {
                if(ta.getNome() == nomeTarefa)
                {
                    bool add = ta.addHoras(horasTrabalhadasnaTarefa);
                    if (add)
                    {
                        horasTrabalhadas += horasTrabalhadasnaTarefa;
                    }
                    else {
                          Console.WriteLine("Não foi possível incluir horas trabalhadas, pois a carga horária está completa");
                    }
                }
            }
        }

        public void executarTarefa(string tarefa)
        {
            foreach(Tarefa ta in tarefas)
            {
                if(ta.getNome() == tarefa)
                {
                    bool terminar = ta.terminarTarefa();
                    if (terminar)
                    {
                        tarefas.Remove(ta);
                        Console.WriteLine("\nTarefa executada\n");
                    }
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Funcionario funcionario &&
                   nome == funcionario.nome;
        }

        public string toString()
        {
            return nome + "\nCargo: " + cargo;
        }
    }
}

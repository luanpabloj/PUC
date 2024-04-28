namespace Prova_questao_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Tarefa> tarefas = new List<Tarefa>();
            int opcao = 0;

            do
            {
                Console.WriteLine("1)Adicionar funcionário\n2)Atribuir tarefas a um funcionário\n3)Executar tarefa de um funcionário\n4)Adicionar horas trabalhadas na tarefa\n5)Listar tarefas existentes\n6)Listar funcionários existentes\n7)Sair");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do funcionário: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite a data de nascimento: ");
                        string dataNascimento = Console.ReadLine();
                        Console.Write("Digite o CPF: ");
                        float cpf = float.Parse(Console.ReadLine());
                        Console.Write("Digite o cargo: ");
                        string cargo = Console.ReadLine();
                        Console.Write("Digite o departamento: ");
                        string departamento = Console.ReadLine();
                        funcionarios.Add(new Funcionario(nome, dataNascimento, cpf, cargo, departamento));
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome da tarefa: ");
                        string nomeTarefa = Console.ReadLine();
                        Console.WriteLine("Digite a carga horária da tarefa: ");
                        double cargaHorariaTarefa = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do funcionário a ser adicionado na tarefa: ");
                        string nomeFuncionarioTarefa = Console.ReadLine();
                        bool addtarefa;
                        foreach(Funcionario f in funcionarios)
                        {
                            if(f.getNome() == nomeFuncionarioTarefa)
                            {
                                addtarefa = f.adicionarTarefa(new Tarefa(nomeTarefa, cargaHorariaTarefa, f));
                                break;
                            }
                            else
                            {
                                addtarefa = false;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do funcionário: ");
                        string nome2 = Console.ReadLine();
                        bool verificarFunc = false;
                        foreach (Funcionario f in funcionarios)
                        {
                            
                            if(f.getNome() == nome2)
                            {
                                verificarFunc = true;
                                Console.WriteLine("Digite o nome da tarefa: ");
                                string nomeTarefaCase3 = Console.ReadLine();
                                bool verificar = false;
                                foreach(Tarefa f2 in tarefas)
                                {
                                    if(f2.getNome() == nomeTarefaCase3)
                                    {
                                        if(f2.Equals(f.getNome()))
                                        {
                                            f.executarTarefa(nomeTarefaCase3);
                                            break;
                                        }
                                        verificar = true;
                                    }
                                    else { verificar = false; }
                                }
                                if(verificar == false) { Console.WriteLine("Tarefa não encontrada"); }
                            }
                            else { verificarFunc = false; }
                        }
                        if(verificarFunc == false)
                        {
                            Console.WriteLine("Funcionário não encontrado\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite o nome do funcionário: ");
                        string nomefuncionariocase4 = Console.ReadLine();
                        bool verificarFuncCase4 = false;
                        foreach (Funcionario f in funcionarios)
                        {

                            if (f.getNome() == nomefuncionariocase4)
                            {
                                verificarFunc = true;
                                Console.WriteLine("Digite o nome da tarefa: ");
                                string nomeTarefaCase4 = Console.ReadLine();
                                bool verificar;
                                foreach (Tarefa f2 in tarefas)
                                {
                                    if (f2.getNome() == nomeTarefaCase4)
                                    {
                                        if (f2.Equals(f.getNome()))
                                        {
                                            Console.WriteLine("Digite a quantidade de horas trabalhadas na tarefa: ");
                                            double horastrabalhadas = double.Parse(Console.ReadLine());
                                            f.addHorasTrabalhadasTarefa(horastrabalhadas, nomeTarefaCase4);
                                        }
                                        verificar = true;
                                    }
                                    else { verificar = false; }
                                    if (verificar == false) { Console.WriteLine("Tarefa não encontrada"); }
                                }
                            }
                            else { verificarFunc = false; }
                        }
                        if (verificarFuncCase4 == false)
                        {
                            Console.WriteLine("Funcionário não encontrado\n");
                        }
                        break;
                    case 5:
                        if(tarefas.Count() > 0)
                        foreach(Tarefa t in tarefas)
                        {
                            Console.WriteLine(t.toString());
                        }
                        else { Console.WriteLine("Não tem tarefas cadastradas\n"); }
                        break;
                    case 6:
                        if (funcionarios.Count() > 0)
                            foreach (Funcionario t in funcionarios)
                            {
                                Console.WriteLine(t.toString());
                            }
                        else { Console.WriteLine("Não tem funcionários cadastrados\n"); }

                      break;
                }
            } while (opcao != 7);
        }
    }
}

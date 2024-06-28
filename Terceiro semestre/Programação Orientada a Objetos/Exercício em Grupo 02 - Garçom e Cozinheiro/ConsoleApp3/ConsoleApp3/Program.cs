namespace ConsoleApp3
{
    internal class Program
    {
        static List<Funcionario> cozinheiros = new List<Funcionario>();
        static List<Funcionario> garcons = new List<Funcionario>();
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1) Acessar menu do garçom\n2) Acessar menu do cozinheiro");
                int op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        MenuGarcom();
                        break;
                    case 2:
                        MenuCozinheiro();
                        break;
                }
            }

        }

        static void MenuGarcom()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("\n1) Cadastrar garçom\n2) Mostrar garçons cadastrados\n3) Mostrar garçom específico\n4) Editar garçom\n5) Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("1. Inserir o nome: ");
                        string name = Console.ReadLine();
                        Console.Write("2. Inserir as horas/dias Trabalhados: (caso seja dias trabalhados, é necessário escolher o regime freelancer): ");
                        double hours = double.Parse(Console.ReadLine());
                        Console.Write("3. Inserir o salário Base: ");
                        double baseSalary = double.Parse(Console.ReadLine());
                        Console.Write("5. Inserir o valor em Vendas: ");
                        double value = double.Parse(Console.ReadLine());
                        Console.Write("7. Inserir o regime: (CLT, FREELANCER ou Horista) ");
                        string regime = Console.ReadLine();
                        if (regime.ToLower() == "clt")
                        {
                            garcons.Add(new Garcom(value, name, hours, baseSalary, new CLT()));
                        }
                        if (regime.ToLower() == "freelancer")
                        {
                            garcons.Add(new Garcom(value, name, hours, baseSalary, new FreeLancer()));
                        }
                        if (regime.ToLower() == "horista")
                        {
                            garcons.Add(new Garcom(value, name, hours, baseSalary, new Horista()));
                        }
                        Console.WriteLine("Garçom cadastrado");
                        break;
                    case 2:
                        if (garcons.Count > 0)
                        {
                            foreach (Funcionario f in garcons)
                            {
                                Console.WriteLine(f.toString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há garçons cadastrados\n");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o ID do garçom: ");
                        long idd = long.Parse(Console.ReadLine());
                        bool falsetrue = false;
                        foreach (Funcionario f in garcons)
                        {
                            if (f.getId() == idd)
                            {
                                Console.WriteLine(f.toString());
                                falsetrue = true;
                                break;
                            }
                        }
                        if (falsetrue == false)
                        {
                            Console.WriteLine("Garçom não encontrado\n");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID do garçom: ");
                        long iddd = long.Parse(Console.ReadLine());
                        bool falsetruee = false;
                        foreach (Funcionario f in garcons)
                        {
                            if (f.getId() == iddd)
                            {
                                MenuEditar(f);
                                falsetruee = true;
                                break;
                            }
                        }
                        if (falsetruee == false)
                        {
                            Console.WriteLine("Garçom não encontrado\n");
                        }
                        break;
                }
            } while (opcao != 5);
        }
    
        static void MenuCozinheiro()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("\n1) Cadastrar cozinheiro\n2) Mostrar cozinheiros cadastrados\n3) Mostrar cozinheiro específico\n4) Editar cozinheiro\n5) Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("1. Inserir o nome: ");
                        string name = Console.ReadLine();
                        Console.Write("2. Inserir as horas/dias Trabalhados: (caso seja dias trabalhados, é necessário escolher o regime freelancer): ");
                        double hours = double.Parse(Console.ReadLine());
                        Console.Write("3. Inserir o salário Base: ");
                        double baseSalary = double.Parse(Console.ReadLine());
                        Console.Write("7. Inserir o regime: (CLT, FREELANCER ou Horista) ");
                        string regime = Console.ReadLine();
                        if (regime.ToLower() == "clt")
                        {
                            cozinheiros.Add(new Funcionario(name, hours, baseSalary, new CLT()));
                        }
                        if (regime.ToLower() == "freelancer")
                        {
                            cozinheiros.Add(new Funcionario(name, hours, baseSalary, new FreeLancer()));
                        }
                        if (regime.ToLower() == "horista")
                        {
                            cozinheiros.Add(new Funcionario(name, hours, baseSalary, new Horista()));
                        }
                        Console.WriteLine("Cozinheiro cadastrado\n");
                        break;
                    case 2:
                        if (cozinheiros.Count > 0)
                        {
                            foreach (Funcionario f in cozinheiros)
                            {
                                Console.WriteLine(f.toString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há cozinheiros cadastrados\n");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o ID do cozinheiro: ");
                        long idd = long.Parse(Console.ReadLine());
                        bool falsetrue = false;
                        foreach (Funcionario f in cozinheiros)
                        {
                            if (f.getId() == idd)
                            {
                                Console.WriteLine(f.toString());
                                falsetrue = true;
                                break;
                            }
                        }
                        if (falsetrue == false)
                        {
                            Console.WriteLine("Cozinheiro não encontrado\n");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID do cozinheiro: ");
                        long iddd = long.Parse(Console.ReadLine());
                        bool falsetruee = false;
                        foreach (Funcionario f in cozinheiros)
                        {
                            if (f.getId() == iddd)
                            {
                                MenuEditar(f);
                                falsetruee = true;
                                break;
                            }
                        }
                        if (falsetruee == false)
                        {
                            Console.WriteLine("Cozinheiro não encontrado\n");
                        }
                        break;
                }
            } while (opcao != 5);
        }

        static void MenuEditar(Funcionario funcionario)
        {
            Console.Write("1) Alterar horas trabalhadas\n2) Alterar base salarial\n3) Alterar regime");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite as horas trabalhadas: ");
                    double horasTrabalhadas = double.Parse(Console.ReadLine());
                    funcionario.setWorkedHours(horasTrabalhadas);
                    Console.WriteLine("Horas trabalhadas modificadas!\n");
                    break;
                case 2:
                    Console.Write("Digite a base salarial: ");
                    double baseSalarial = double.Parse(Console.ReadLine());
                    funcionario.setBaseSalary(baseSalarial);
                    break;
                case 3:
                    Console.WriteLine("Selecione o regime:\n1) CLT\n2) FreeLancer\n3) Horista");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            funcionario.setRegime(new CLT());
                            Console.WriteLine("Regime alterado!!\n");
                            break;
                        case 2:
                            funcionario.setRegime(new FreeLancer());
                            Console.WriteLine("Regime alterado!!\n");
                            break;
                        case 3:
                            funcionario.setRegime(new Horista());
                            Console.WriteLine("Regime alterado!!\n");
                            break;
                    }
                    break;
            }
        }
    }
}

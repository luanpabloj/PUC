namespace ConsoleApp5
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Porta portaRecepcao = new Recepcao();
            Porta portaRestrita = new Restrita();
            Porta portaCofre = new Cofre();

            while (true)
            {
                Console.WriteLine("Selecione a porta:");
                Console.WriteLine("1. Porta da Recepção");
                Console.WriteLine("2. Porta de Acesso Restrito");
                Console.WriteLine("3. Porta do Cofre");
                Console.WriteLine("4. Sair");
                int portaEscolhida = int.Parse(Console.ReadLine());

                if (portaEscolhida == 4) break;

                Console.WriteLine("Selecione o tipo de usuário:");
                Console.WriteLine("1. Segurança");
                Console.WriteLine("2. Funcionário");
                Console.WriteLine("3. Gerente Geral");
                int usuarioEscolhido = int.Parse(Console.ReadLine());
                TipoUsuario tipoUsuario = (TipoUsuario)usuarioEscolhido;

                switch (portaEscolhida)
                {
                    case 1:
                        portaRecepcao.Abrir(tipoUsuario);
                        break;
                    case 2:
                        portaRestrita.Abrir(tipoUsuario);
                        break;
                    case 3:
                        if (!portaCofre.PodeAbrir(tipoUsuario))
                        {
                            Console.WriteLine("Esperando 1 hora...");
                            await Task.Delay(3600000);
                            portaCofre.Abrir(tipoUsuario);
                        }
                        else
                        {
                            portaCofre.Abrir(tipoUsuario);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
    }
}

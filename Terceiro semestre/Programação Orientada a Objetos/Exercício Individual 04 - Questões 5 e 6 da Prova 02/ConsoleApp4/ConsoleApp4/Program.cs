namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuCalculadora();
        }

        static void MenuCalculadora()
        {
            while (true) {
            Console.WriteLine("\n\n1) Adição\n2) Subtração\n3) Multiplicação\n4) Divisão\n5) Potência\n6) Raiz quadrada\n7) Científica\n8) Financeiro\n9) Programador");
            int opcao = int.Parse(Console.ReadLine());
            long y, x;
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite o número Y: ");
                        y = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Calculadora.Adicao(x, y));
                        break;
                    case 2:
                        Console.Write("Digite o número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite o número Y: ");
                        y = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Calculadora.Subtracao(x, y));
                        break;
                    case 3:
                        Console.Write("Digite o número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite o número Y: ");
                        y = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Calculadora.Multiplicacao(x, y));
                        break;
                    case 4:
                        Console.Write("Digite o número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite o número Y: ");
                        y = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Calculadora.Divisao(x, y));
                        break;
                    case 5:
                        Console.Write("Digite o número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite o número Y: ");
                        y = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Calculadora.Potencia(x, y));
                        break;
                    case 6:
                        Console.Write("Digite o número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Calculadora.RaizQuadrada(x));
                        break;
                    case 7:
                        MenuCientifica();
                        break;
                    case 8:
                        MenuFinanceiro();
                        break;
                    case 9:
                        MenuProgramador();
                        break;
                }
            }
        }

        static void MenuCientifica()
        {
            double x, opcao;
            do
            {
                Console.WriteLine("\n\n1) Logaritmo\n2) Logaritmo base 10\n3) Seno\n4) Cosseno\n5) Tangente\n6) Sair");
                opcao = double.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Cientifica.Logaritmo(x));
                        break;
                    case 2:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Cientifica.LogaritmoBase10(x));
                        break;
                    case 3:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Cientifica.Seno(x));
                        break;
                    case 4:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Cientifica.Cosseno(x));
                        break;
                    case 5:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Cientifica.Tangente(x));
                        break;
                }
            } while (opcao != 6);
        }

        static void MenuFinanceiro()
        {
            double x, opcao, y, z;
            do
            {
                Console.WriteLine("\n\n1) Juros Simples\n2) Juros Compostos\n3) Pagamento Empréstimo\n4) Valor Futuro\n5) Valor Presente\n6) Sair");
                opcao = double.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Digite a taxa: ");
                        y = double.Parse(Console.ReadLine());
                        Console.Write("Digite o tempo: ");
                        z = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Financeiro.JurosSimples(x, y, z));
                        break;
                    case 2:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Digite a taxa: ");
                        y = double.Parse(Console.ReadLine());
                        Console.Write("Digite o tempo: ");
                        z = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Financeiro.JurosCompostos(x, y, z));
                        break;
                    case 3:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Digite a taxa: ");
                        y = double.Parse(Console.ReadLine());
                        Console.Write("Digite o número de parcelas: ");
                        z = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Financeiro.PagamentoEmprestimo(x, y, z));
                        break;
                    case 4:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Digite a taxa: ");
                        y = double.Parse(Console.ReadLine());
                        Console.Write("Digite o tempo: ");
                        z = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Financeiro.ValorFuturo(x, y, z));
                        break;
                    case 5:
                        Console.Write("Digite o número X: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Digite a taxa: ");
                        y = double.Parse(Console.ReadLine());
                        Console.Write("Digite o tempo: ");
                        z = double.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Financeiro.ValorPresente(x, y, z));
                        break;
                }
            } while (opcao != 6);
        }

        static void MenuProgramador()
        {
            string a;
            long x, z;
            int opcao, y;
            do
            {
                Console.WriteLine("\n\n1) Decimal para binário\n2) Decimal para hexadecimal\n3) Decimal para Octal\n4) Binário para decimal\n5) Hexadecimal para Decimal\n6) Octal para decimal\n7) And\n8) Or\n9) Xor\n10) Not\n11) Shift Left\n12) Shift Right\n13) Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.DecimalParaBinario(x));
                        break;
                    case 2:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.DecimalParaHexadecimal(x));
                        break;
                    case 3:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.DecimalParaOctal(x));
                        break;
                    case 4:
                        Console.Write("Digite número X: ");
                        a = Console.ReadLine();
                        Console.Write("Resultado: " + Programador.BinarioParaDecimal(a));
                        break;
                    case 5:
                        Console.Write("Digite número X: ");
                        a = Console.ReadLine();
                        Console.Write("Resultado: " + Programador.HexadecimalParaDecimal(a));
                        break;
                    case 6:
                        Console.Write("Digite número X: ");
                        a = Console.ReadLine();
                        Console.Write("Resultado: " + Programador.OctalParaDecimal(a));
                        break;
                    case 7:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite número Y: ");
                        z = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.And(x, z));
                        break;
                    case 8:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite número Y: ");
                        z = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.Or(x, z));
                        break;
                    case 9:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite número Y: ");
                        z = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.Xor(x, z));
                        break;
                    case 10:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.Not(x));
                        break;
                    case 11:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite número Y: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.ShiftLeft(x, y));
                        break;
                    case 12:
                        Console.Write("Digite número X: ");
                        x = long.Parse(Console.ReadLine());
                        Console.Write("Digite número Y: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Resultado: " + Programador.ShiftRight(x, y));
                        break;
                }
            } while (opcao != 13);
            }
        }
    }


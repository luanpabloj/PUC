using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto");
            int produto = int.Parse(Console.ReadLine());

            switch (produto)
            {
                case 11:
                Console.WriteLine("arroz");
                break;

                case 12:
                Console.WriteLine("feijão");
                break;

                case 13:
                Console.WriteLine("batata");
                break;

                case 14:
                Console.WriteLine("carne");
                break;


                default:
                Console.WriteLine("produto não encontrado");
                break;
            }

            Console.WriteLine("Luan Pablo Mendes Amaral");

        }
    }
}

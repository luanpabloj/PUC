using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o código do produto");
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                Console.WriteLine("Alimento não-perecível");
                break;

                case 2:
                Console.WriteLine("Alimento perecível");
                break;

                case 3:
                Console.WriteLine("Alimento perecível");
                break;

                case 4:
                Console.WriteLine("Alimento perecível");
                break;

                case 5:
                Console.WriteLine("Vestuário");
                break;

                case 6:
                Console.WriteLine("Vestuário");
                break;

                case 7:
                Console.WriteLine("Higiene pessoal");
                break;

                case 8:
                Console.WriteLine("Limpeza");
                break;


                default:
                Console.WriteLine("Código inválido");
                break;
            }

        Console.WriteLine("Luan Pablo Mendes Amaral");

        }
    }
}

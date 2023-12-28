using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 0:
                Console.WriteLine("Vermelho");
                break;

                case 1:
                Console.WriteLine("Branco");
                break;

                case 2:
                Console.WriteLine("Preto");
                break;



                default:
                Console.WriteLine("Valor não encontrado no banco de dados");
                break;
            }

            Console.WriteLine("Luan Pablo Mendes Amaral");


        }
    }
}

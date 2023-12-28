using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            string operacao="";
            Console.WriteLine("Digite a operação");
            operacao = Console.ReadLine();

            int resultado=0;

            switch (operacao)
            {
                case "multiplicacao":
                resultado = valor1 * valor2;
                Console.WriteLine(resultado);
                break;

                case "divisao":
               resultado = valor1/valor2;
                Console.WriteLine(resultado);
                break;

                case "adicao":
                resultado = valor1 + valor2;
                Console.WriteLine(resultado);
                break;

                case "subtracao":
                resultado = valor1 - valor2;
                Console.WriteLine(resultado);
                break;



                default:
                Console.WriteLine("operação não encontrada");
                break;
            }

            Console.WriteLine("Luan Pablo Mendes Amaral");
        }
    }
}

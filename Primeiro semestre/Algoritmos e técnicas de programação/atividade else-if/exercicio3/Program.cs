using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade=0;

            Console.WriteLine("Digite o ano atual: ");
            int anoatual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            idade = anoatual - nascimento;

            if(idade < 18){
                Console.WriteLine("A pessoa é maioridade civil");
            }

            else{
                Console.WriteLine("A pessoa é maioridade penal");
            }

            Console.WriteLine("Luan Pablo Mendes Amaral");
        }
    }
}

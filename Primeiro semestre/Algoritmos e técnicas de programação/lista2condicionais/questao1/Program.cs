using System;

namespace lista2condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de ração a ser adicionada no estoque");

            int quantidade = int.Parse(Console.ReadLine());

            
            if(quantidade > 100){
                Console.WriteLine("Status: suficiente");
            }

            else if(quantidade >= 50 && quantidade <= 100){
                Console.WriteLine("Status: alerta!!");
            }

            else{
                Console.WriteLine("Status: abaixo do ideal");
            }

        }
    }
}

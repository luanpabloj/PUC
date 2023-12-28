using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            if(codigo == 11){
                Console.WriteLine("Arroz");
            }

            else if(codigo == 12){
                Console.WriteLine("Feijão");
            }
            else if(codigo == 13){
                Console.WriteLine("Batata");
            }
            else if(codigo == 14){
                Console.WriteLine("Carne");
            }
            else{
                Console.WriteLine("Código inválido");
            }
            
            Console.WriteLine("Luan Pablo Mendes Amaral");
        }
    }
}

using System;

namespace questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] vetorX = new int [10];
            int [] vetorY = new int [10];
            int soma = 0, produto = 1;

            Console.WriteLine("Digite 10 valores para o vetor X");
            
            for(int i = 0; i < 10; i++){
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite 10 valores para o vetor Y");

            for(int i = 0; i < 10; i++){
                vetorY[i] = int.Parse(Console.ReadLine());
            }


           for(int i = 0; i < 10; i++){
            soma+= vetorX[i] + vetorY[i];
        }

           Console.WriteLine("Soma dos vetores Y e X: " + soma);


            for(int i = 0; i < 10; i++){
            produto*= vetorX[i] * vetorY[i];    
            }

            Console.WriteLine("Produtos dos vetores X e Y: " + produto);

        }
    }
}

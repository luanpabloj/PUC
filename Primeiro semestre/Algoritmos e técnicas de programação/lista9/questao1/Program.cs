using System;

namespace lista_9
{
    class Program
    {
        static void Main(string[] args)
        {

                 int[] vetorA = new int[10];
                 int[] vetorB = new int[10];
                
                Console.WriteLine("Digite 10 valores para ser alocados no vetor A");
                preencherVetorA(vetorA);


                fatorial(vetorA, vetorB);
                mostrarVetor(vetorB);


        }

        static void preencherVetorA(int[] vetorA){

            for(int i = 0; i < 10; i++){
                vetorA[i] = int.Parse(Console.ReadLine());
            }
        }




       static void fatorial(int[] vetorA, int[] vetorB){

            for(int i = 0; i < vetorA.Length; i++){
                int fatorial = 1;

                for(int j = 1; j <= vetorA[i]; j++){

                    fatorial*= j;
                }

                vetorB[i] = fatorial;
                
            }
        }

        static void mostrarVetor(int[] vetorA){

            for(int i = 0; i < 10; i++){
                Console.WriteLine(vetorA[i]);
            }
        }
    }
}
using System;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetorNum = new int[8];
            int [] vetor1 = new int[8];
            int [] vetor2 = new int[8];
            int j = 0, k = 0;


            Console.WriteLine("Digite 8 valores");

            for(int i = 0; i < 8; i++){
                
                vetorNum[i] = int.Parse(Console.ReadLine());

                if(vetorNum[i] >= 0){
                    vetor1[j] = vetorNum[i];
                    j++;
                }

                else {
                    vetor2[k] = vetorNum[i];
                    k++;
                    }
            }
                    for(int i = 0; i < j; i++){
                        Console.WriteLine("Números positivos: " + vetor1[i]);
                    }

                     for(int i = 0; i < k; i++){
                        Console.WriteLine("Números negativo: " + vetor2[i]);
                    }
            }
        }
    }


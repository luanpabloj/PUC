using System;

namespace questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0, cont=1, soma=0;
            double quadrado=0, cubo=0, raiz=0;

            do{
                Console.WriteLine("Digite o valor do produto: ");
                num = int.Parse(Console.ReadLine());

                soma+= num;
                quadrado = Math.Pow(soma, 2);
                cubo = Math.Pow(soma, 3);
                raiz = Math.Sqrt(soma);

                if(cont % 20 == 0){
                    Console.WriteLine("soma dos valores digitados: " + soma);
                    Console.WriteLine("valor ao quadrado dos valores digitados: " + quadrado);
                    Console.WriteLine("valor ao cubo dos valores digitados: " + cubo);
                    Console.WriteLine("raiz dos valores digitados: " + raiz);



                }

                if(num == 0 || num < 0){
                    break;
                }

                cont++;
            }
            while(true);




        }
    }
}

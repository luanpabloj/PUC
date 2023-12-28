using System;

namespace questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            float num=0, soma=0, media=0, maior=0, menor=9999, impar=0, porcen=0; 
            int cont=1;


            do{
                Console.WriteLine("Digite o valor do produto: ");
                num = float.Parse(Console.ReadLine());

                soma+= num;
                media = (float)soma/cont;

                if(num > maior){
                    maior = num;
                }
                if(num < menor){
                    menor = num;
                }

                if(num % 2 != 0){
                    impar++;
                }
                porcen = (float)impar/cont*100;

                if(cont % 20 ==0){
                Console.WriteLine("A soma dos números digitados: " + soma);
                Console.WriteLine("A quantidade de números digitados: " + cont);
                Console.WriteLine("A média dos números digitados: " + media);
                Console.WriteLine("O menor número digitado " + menor);
                Console.WriteLine("O maior número digitado: " + maior);
                Console.WriteLine("A porcentagem dos números ímpares entre todos os números digitados: " + porcen);
                }



                cont++;
            }
            while(num != 30000);

        }
    }
}

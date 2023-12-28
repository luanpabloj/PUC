using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            String npar, negativo;

            Console.WriteLine("Digite o número: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0){
                npar = "par";
            }

            else{
                npar = "impar";
            }

            if(numero < 0){
                negativo = "negativo";
            }

            else{
                negativo = "positivo";
            }

            Console.WriteLine("O número digitado é: " + npar + " e " + negativo);

            Console.WriteLine("Luan Pablo Mendes Amaral");

        }
    }
}

using System;

namespace questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            float salMin=0, watts=0, valorWatts=0, apagarWatts=0;
            int tipo=0, qntconsu=0;


            do{
                Console.WriteLine("Digite o valor do salário mínimo: ");
                salMin = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de quilo watts gasto: ");
                watts = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tipo de consumidor: ");
                tipo = int.Parse(Console.ReadLine());

                valorWatts = salMin/8;
                Console.WriteLine("O valor de cada quilowatt: R$" + valorWatts);


                if(tipo == 1){
                    apagarWatts = (float)(valorWatts * watts)*1.05F;
                    Console.WriteLine("O valor a ser pago na residência: R$" + apagarWatts);
                    if(apagarWatts > 500 && apagarWatts < 1000){
                        qntconsu++;
                    }

                }
                else if(tipo == 2){
                    apagarWatts = (float)(valorWatts * watts)*1.10F;
                    Console.WriteLine("O valor a ser pago no comercio: R$" + apagarWatts);
                    if(apagarWatts > 500 && apagarWatts < 1000){
                        qntconsu++;
                    }
                }
                else if(tipo == 3){
                    apagarWatts = (float)(valorWatts * watts)*1.15F;
                    Console.WriteLine("O valor a ser pago na indústria: R$" + apagarWatts);
                    if(apagarWatts > 500 && apagarWatts < 1000){
                        qntconsu++;
                    }
                }
                

                Console.WriteLine("A quantidade de consumidores que pagam entre R$ 500,00 e R$ 1000,00: " + qntconsu);
                

            }
            while(watts != 0);
        }
    }
}

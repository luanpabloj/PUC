using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {

        double reajuste=0;

        Console.WriteLine("Digite o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do produto: ");
        float valor = float.Parse(Console.ReadLine());

        if(valor <= 100){
            reajuste = valor * 1.10;
        }
        else if(valor <= 500){
            reajuste = valor * 1.13;
        }
        else if(valor <= 800){
            reajuste = valor * 1.15;
        }
        else if(valor <= 1500){
            reajuste = valor * 1.08;
        }

        Console.WriteLine("O valor do produto código " + codigo + " que custava " + valor + " foi reajustado para " + reajuste);

        Console.WriteLine("Luan Pablo Mendes Amaral");

        }
    }
}

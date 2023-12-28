using System;

namespace questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números");
            int lado1 = int.Parse(Console.ReadLine());
            int lado2 = int.Parse(Console.ReadLine());
            int lado3 = int.Parse(Console.ReadLine());


            if((lado1 != lado2) && (lado1 != lado3) && (lado2 != lado3)){
                Console.WriteLine("Escaleno");
            }
            else if((lado1 == lado2)&&(lado1 != lado3) || (lado2 == lado3)&&(lado2 != lado1) || (lado3 == lado1)&&(lado3 != lado1)){
                Console.WriteLine("Isósceles");
            }
            else{
                Console.WriteLine("Equilátero");
            }
        }
    }
}

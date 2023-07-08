using System;

namespace questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do trabalho de laboratório");
            int lab = int.Parse(Console.ReadLine())*2;

            Console.WriteLine("Digite a nota da avaliação semestral");
            int semestral = int.Parse(Console.ReadLine())*3;

            Console.WriteLine("Digite a nota do exame final");
            int examefinal = int.Parse(Console.ReadLine())*5;


            int mediap=0;

            mediap = (lab + semestral + examefinal)/10;

            if(mediap >= 8 && mediap <=10){
                Console.WriteLine("Conceito A");
            }

            else if(mediap >= 7 && mediap <=8){
                Console.WriteLine("Conceito B");
            }

            else if(mediap >= 6 && mediap <=7){
                Console.WriteLine("Conceito C");
            }

            else if(mediap >= 5 && mediap <=6){
                Console.WriteLine("Conceito D");
            }

            else{
                Console.WriteLine("Conceito E");
            }

        }
    }
}

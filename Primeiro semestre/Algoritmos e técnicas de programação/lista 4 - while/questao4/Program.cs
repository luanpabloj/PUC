int i = 0;

while (i < 5)
{

    Console.WriteLine("Digite três valores");
    double ladoA = double.Parse(Console.ReadLine());
    double ladoB = double.Parse(Console.ReadLine());
    double ladoC = double.Parse(Console.ReadLine());

        if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Não formam um triângulo");
        }


        i++;
    }
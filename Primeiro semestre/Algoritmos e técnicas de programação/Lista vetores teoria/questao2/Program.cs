int[] vetor = new int[100];


Console.WriteLine("Digite 100 valores inteiros");

for (int i = 0; i < 100; i++)
{

    vetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 100; i++)
{

    if (vetor[i] == 0)
    {

        Console.WriteLine("Posições do vetor que tem o valor 0: " + i);

    }

}
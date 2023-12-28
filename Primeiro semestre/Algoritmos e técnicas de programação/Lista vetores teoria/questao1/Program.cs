int cont = 0;

int[] vetor = new int[30];

Console.WriteLine("Digite 30 números quaisquer do tipo inteiro");

for (int i = 0; i < 30; i++)
{

    vetor[i] = int.Parse(Console.ReadLine());

}


for (int i = 0; i < 30; i++)
{

    if (vetor[i] == 10)
    {
        cont++;
    }
}

Console.WriteLine("Números de elementos iguais a 10: " + cont);
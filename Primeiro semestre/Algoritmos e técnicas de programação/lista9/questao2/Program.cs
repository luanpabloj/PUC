int[] vetorA = new int[5];
int auxiliar = 0;


valoresVetorA(vetorA);
ordenado(vetorA);
imprimir(vetorA);

void valoresVetorA(int[] vetorA)
{

    Console.WriteLine("Digite 5 números para o vetor A");

    for (int i = 0; i < 5; i++)
    {
        vetorA[i] = int.Parse(Console.ReadLine());
    }

}


void ordenado(int[] vetorA)
{

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            if (vetorA[i] < vetorA[j])
            {
                auxiliar = vetorA[i];
                vetorA[i] = vetorA[j];
                vetorA[j] = auxiliar;
            }
        }
    }


}


void imprimir(int[] vetorA)
{

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Vetor organizado em ordem crescente: " + vetorA[i]);

    }

}

Console.WriteLine("Defina o tamanho do vetor A");
int tamanho = int.Parse(Console.ReadLine());


double[] vetorA = new double[tamanho];


valoresVetorA(vetorA, tamanho);
duasUnidades(vetorA, tamanho);
umaUnidade(vetorA);
multiplicar(vetorA);
elevado(vetorA);


void valoresVetorA(double[] vetorA, int tamanho)
{


    Console.WriteLine("Digite " + tamanho + " valores para preencher o vetor A");

    for (int i = 0; i < tamanho; i++)
    {

        vetorA[i] = double.Parse(Console.ReadLine());

    }

}

void duasUnidades(double[] vetorA, int tamanho)
{

    double[] vetorduasUnidades = new double[tamanho];


    for (int i = 0; i < tamanho; i++)
    {
        vetorduasUnidades[i] = vetorA[i];
        vetorduasUnidades[i] += 2;
        
    }

    Console.WriteLine("Valores do vetor A acrescidos de 2 unidades: ");

    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine(vetorduasUnidades[i]);
    }


}

void umaUnidade(double[] vetorA)
{

    double[] vetorumaUnidade = new double[tamanho];

    for (int i = 0; i < tamanho; i++)
    {
        vetorumaUnidade[i] = vetorA[i];
        vetorumaUnidade[i] -= 1;

    }

    Console.WriteLine("Valores do vetor A reduzidos em 1 unidade:");

    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine(vetorumaUnidade[i]);
    }

}

void multiplicar(double[] vetorA)
{

    double[] vetormultiplicar = new double[tamanho];

    Console.WriteLine("Valores do vetor A: ");
    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine(vetorA[i]);
    }

    for (int i = 0; i < tamanho; i++)
    {
        vetormultiplicar[i] = vetorA[i];
        vetormultiplicar[i] *= 2;

    }

    Console.WriteLine("Valores do vetor A multiplicados por 2: ");

    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine(vetormultiplicar[i]);
    }


}

void elevado(double[] vetorA)
{

    double[] vetorelevado = new double[tamanho];

    for (int i = 0; i < tamanho; i++)
    {
        vetorelevado[i] = vetorA[i];
        vetorelevado[i] *= vetorelevado[i];
    }

    Console.WriteLine("Valores do vetor A elevados ao quadrado: ");

    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine(vetorelevado[i]);
    }

}
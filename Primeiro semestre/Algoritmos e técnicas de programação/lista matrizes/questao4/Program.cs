double[,] matriz = new double[3, 4];
double[] vetor = new double[12];

Random random = new Random();

preencherMatriz(matriz);
preencherVetor(matriz, vetor);

void preencherMatriz(double[,] matriz)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matriz[i, j] = random.NextDouble();
        }
    }
}

void preencherVetor(double[,] matriz, double[] vetor)
{
    int cont = 0;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            vetor[cont] = matriz[i, j];
            cont++;
        }
    }

    for (int i = 0; i < 12; i++)
    {
        Console.WriteLine("Vetor: " + vetor[i]);
    }
}

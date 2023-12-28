
Random random = new Random();


double[,] numeros = new double[6, 4];
preenchermatriz(numeros, random);
mediaM(numeros);

void preenchermatriz(double[,] numeros, Random random)
{
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 4; j++)
        {

            numeros[i, j] = random.NextDouble();
        }
    }
}

double mediaM(double[,] numeros)
{
    double soma=0;
    double mediaMatriz = 0;

    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            soma+= numeros[i, j];
        }
    }

    mediaMatriz = soma/24;

    Console.WriteLine("Média da matriz: " + mediaMatriz);


    return mediaMatriz;

}
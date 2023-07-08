int[] numeros = new int[5];
preencherVetor(numeros);
maior(numeros);
menor(numeros);


void preencherVetor(int[] numeros)
{

    Console.WriteLine("Digite 5 valores inteiros");
    for (int i = 0; i < 5; i++)
    {
        numeros[i] = int.Parse(Console.ReadLine());
    }
}


void maior(int[] numeros)
{
    int maiorNum = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (numeros[i] > numeros[j])
            {
                maiorNum = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = maiorNum;
            }
        }
    }

    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"Maior valor: {numeros[i]}");
    }

}


void menor(int[] numeros)
{
    int menorNum = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            if (numeros[i] < numeros[j])
            {

                menorNum = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = menorNum;

            }

        }
    }


    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"Menor valor: {numeros[i]}");
    }

}
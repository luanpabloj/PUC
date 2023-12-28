

int[,] numeros = new int[5, 5];

Random random = new Random();


preenchermatriz(numeros);
linhaQuatro(numeros);
colunaDois(numeros);

void preenchermatriz(int[,] numeros)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            numeros[i, j] = random.Next();
        }
    }
}


int linhaQuatro(int[,] numeros){

    int soma = 0;


    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            soma+= numeros[4, j];
        }
    }

    Console.WriteLine("Soma dos elementos da linha 4: " + soma);

    return soma;
}


int colunaDois(int[,] numeros){

    int soma = 0;


    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            soma+= numeros[i, 2];
        }
    }

    Console.WriteLine("Soma dos elementos da coluna 2: " + soma);

    return soma;
}
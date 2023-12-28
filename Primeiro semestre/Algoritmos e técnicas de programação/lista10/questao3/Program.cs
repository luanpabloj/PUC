
int[,] numeros = new int[3, 3];

preenchermatriz(numeros);
multiplicacao(numeros);

void preenchermatriz(int[,] numeros)
{

    Console.WriteLine("Digite 9 valores para preencher a matriz: ");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            numeros[i, j] = int.Parse(Console.ReadLine());
        }
    }


}

int multiplicacao(int[,] numeros){

    int multi=0;
    int soma=0;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            soma+= numeros[i, j];
        }
    }

    multi = soma * (3*3);
    
    Console.WriteLine("Resultado da multiplicação da soma dos números da matriz: " + multi);

    return multi;
}
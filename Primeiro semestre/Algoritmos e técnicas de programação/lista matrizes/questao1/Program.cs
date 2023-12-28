int[,] matrizM = new int[2, 2];
int[,] matrizR = new int[2, 2];


preencherVetorM(matrizM);
preencherVetorR(matrizM, matrizR);


void preencherVetorM(int[,] matrizM)
{
    Console.WriteLine("Digite 4 valores para preencher a matriz M");


    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            matrizM[i, j] = int.Parse(Console.ReadLine());
        }
    }
}



void preencherVetorR(int[,] matrizM, int[,] matrizR)
{
    int[] auxiliarMatriz = new int[4];
    int auxiliarOrdenar = 0;
    int auxiliar = 0;
    int maiorValor = 0;

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            auxiliarMatriz[auxiliar] = matrizM[i, j];
            auxiliar++;
        }
    }


    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (auxiliarMatriz[i] > auxiliarMatriz[j])
            {
                auxiliarOrdenar = auxiliarMatriz[j];
                auxiliarMatriz[j] = auxiliarMatriz[i];
                auxiliarMatriz[i] = auxiliarOrdenar;
            }
        }
    }


    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            matrizR[i, j] = maiorValor*matrizM[i, j];
        }
    }


        for (int i = 0; i < 1; i++)
    {
        maiorValor = auxiliarMatriz[i];
    }

    
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            matrizR[i, j] = maiorValor * matrizM[i, j];
        }
    }

    Console.WriteLine("Matriz R: ");
    
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.WriteLine(matrizR[i, j]);
        }
    }

}


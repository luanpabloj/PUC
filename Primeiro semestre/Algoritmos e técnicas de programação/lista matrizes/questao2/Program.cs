double[,] notasAlunos = new double[10, 3];
double[,] matrizAuxiliarNotas = new double[10, 3];
int contadorAlunos = 0;

preencherMatriz(notasAlunos, matrizAuxiliarNotas);
relatorio(notasAlunos, matrizAuxiliarNotas);
relatorioDois(notasAlunos, matrizAuxiliarNotas);

void preencherMatriz(double[,] notasAlunos, double[,] matrizAuxiliarNotas)
{

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Digite três notas para o aluno: " + (i+1));

        for (int j = 0; j < 3; j++)
        {
            notasAlunos[i, j] = double.Parse(Console.ReadLine());
        }
    }
}


void relatorio(double[,] notasAlunos, double[,] matrizAuxiliarNotas)
{

    double auxiliarNotas = 0;

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrizAuxiliarNotas[i, j] = notasAlunos[i, j];
        }
    }

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            if (matrizAuxiliarNotas[i, j] > matrizAuxiliarNotas[i, j + 1])
            {
                auxiliarNotas = matrizAuxiliarNotas[i, j];
                matrizAuxiliarNotas[i, j] = matrizAuxiliarNotas[i, j + 1];
                matrizAuxiliarNotas[i, j + 1] = auxiliarNotas;
            }
        }
    }



    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Aluno número: " + (i+1));
        Console.WriteLine("Menor nota: ");
        for (int j = 0; j < 1; j++)
        {
            Console.WriteLine(matrizAuxiliarNotas[i, 0]);
        }
    }


}





void relatorioDois(double[,] notasAlunos, double[,] matrizAuxiliarNotas)
{
    int provaUm = 0, provaDois = 0, provaTres = 0;

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 1; j++)
        {

            if (notasAlunos[i, j] > notasAlunos[i, j + 1] && notasAlunos[i, j] > notasAlunos[i, j + 2])
            {
                provaUm++;
            }

            else if (notasAlunos[i, j + 1] > notasAlunos[i, j] && notasAlunos[i, j + 1] > notasAlunos[i, j + 2])
            {
                provaDois++;
            }

            else if (notasAlunos[i, j + 2] > notasAlunos[i, j] && notasAlunos[i, j + 2] > notasAlunos[i, j + 1])
            {
                provaTres++;
            }


        }
    }

    Console.WriteLine(provaUm + " alunos tiveram menores notas na primeira prova");
    Console.WriteLine(provaDois + " alunos tiveram menores notas na segunda prova");
    Console.WriteLine(provaTres + " alunos tiveram menores notas na terceira prova");

}
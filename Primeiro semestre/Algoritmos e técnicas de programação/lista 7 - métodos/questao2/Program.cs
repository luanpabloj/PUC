double[] notas = new double[3];
double[] pesos = new double[]{5,3,2};
double media = notasAluno(notas, pesos);

Console.WriteLine($"Nota do aluno: {media}");


double notasAluno(double[] notas, double[] pesos)
{

    string letra="";
    double media = 0;

    Console.WriteLine("Digite três notas para o aluno X");
    for (int i = 0; i < 3; i++)
    {
        notas[i] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine("Digite a letra P para ser realizado a média ponderada ou A para a média aritmética");
    letra = Console.ReadLine();

    if (letra == "P" || letra == "p")
    {
        for (int i = 0; i < 3; i++)
        {
            media+= notas[i] * pesos[i] / 10;
        }
    }
    else if(letra == "A" || letra == "a")
    {
        for (int i = 0; i < 3; i++)
        {
            media+= notas[i]/3;
        }

    }

    return media;

}
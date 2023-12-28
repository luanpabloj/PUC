using System.IO;

double numero = 0;
double calculo = 1;


StreamWriter arquivo = new StreamWriter("resultados.txt");


for(int i = 0; i < 2; i++)
{
    Console.WriteLine("Digite o valor de I");
    numero = double.Parse(Console.ReadLine());

    for(int j = 3; j < 100; j++)
    {
        calculo*= (numero - 1/((j-1)*j));

    }

    arquivo.WriteLine("Resultado: " + calculo);

}


arquivo.Close();
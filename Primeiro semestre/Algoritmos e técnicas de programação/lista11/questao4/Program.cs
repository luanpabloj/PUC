
string resultado = "";



Console.WriteLine("Digite uma frase:");
string input = Console.ReadLine();

string[] palavras = input.Split(' ');

duplicar(palavras, resultado);


void duplicar(string[] plavras, string resultado)
{

    for (int i = 0; i < palavras.Length; i++)
    {
        resultado += palavras[i] + " " + palavras[i] + " ";
    }

    Console.WriteLine("Saída: " + resultado.Trim());


}
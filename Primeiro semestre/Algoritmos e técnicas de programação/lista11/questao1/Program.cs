string mensagem = "";

Console.WriteLine("Digite uma frase");
mensagem = Console.ReadLine();



qntPalavras(mensagem);




void qntPalavras(string mensagem)
{
    string[] _split = mensagem.Split(" ");
    int cont = 0;
    for (int i = 0; i < _split.Length; i++)
    {
        cont++;
    }

    Console.WriteLine("Quantidade de palavras digitadas na frase: " + cont);

}
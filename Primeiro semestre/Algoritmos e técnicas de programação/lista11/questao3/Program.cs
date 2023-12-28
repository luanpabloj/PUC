string mensagem = "";

Console.WriteLine("Digite uma palavra");
mensagem = Console.ReadLine();


var mensagemInvertida = new string(mensagem.Reverse().ToArray());


verificacao(mensagem, mensagemInvertida);





void verificacao(string mensagem, string mensagemInvertida)
{
    if (mensagem.Equals(mensagemInvertida))
    {
        Console.WriteLine("Palavra informada é palíndromo.");
    }
    else
    {
        Console.WriteLine("Palavra informada não é palíndromo.");
    }


}
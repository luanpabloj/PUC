namespace questao5;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        inverter(frase);

    }

    static void inverter(string frase){

        Stack<char> pilha = new Stack<char>();
        string mensagem = "";

        foreach(char i in frase){
            pilha.Push(i);
        }

        char[] auxiliar = new char[pilha.Count];
        for(int i = 0; i < auxiliar.Length; i++){
            auxiliar[i] = pilha.Pop();
        }

        foreach(char i in auxiliar){
            mensagem+= i;
        }

        Console.Write(mensagem);
    }

}
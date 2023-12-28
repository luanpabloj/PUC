using System.Diagnostics;

namespace questao_4;
class Program
{
    static void Main(string[] args)
    {
        List<string> sinonimos = new List<string>();
        SortedList<string, List<string>> palavras = new SortedList<string, List<string>>();

        int opcao = 0;

        do{

            Console.WriteLine("1 - Adicionar uma nova palavra e seus sinônimos\n2 - Pesquisar os sinônimos de uma palavra em específico\n3 - Exibir o dicionário em ordem alfabética das palavras\n4 - Sair");
            opcao = int.Parse(Console.ReadLine());
            switch(opcao){
                case 1:
                    preencher(palavras, sinonimos);
                break;
                case 2:
                    pesquisar(palavras, sinonimos);
                break;
                case 3:
                    alfabetica(palavras, sinonimos);
                break;
            }
        }while(opcao != 4);
    }

    static void preencher(SortedList<string, List<string>> palavras, List<string> sinonimos){
        List<string> teste = new List<string>();
        Console.Write("Digite a palavra: ");
        string palavra = Console.ReadLine();
        Console.Write("Digite três sinônimos: ");
        for(int i = 0; i < 3; i++){
            string sinonimo = Console.ReadLine();
            teste.Add(sinonimo);
        }

        palavras.Add(palavra, teste);
    }

    static void pesquisar(SortedList<string, List<string>> palavras, List<string> sinonimos){
        Console.Write("Digite a palavra que deseja saber os sinônimos: ");
        string palavra = Console.ReadLine();

        foreach (var i in palavras){
            if (i.Key == palavra){
                Console.Write("Sinônimos da palavra " + palavra + ": ");
                 foreach (var sinonimo in i.Value){
                    Console.Write(sinonimo + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
        }

    static void alfabetica(SortedList<string, List<string>> palavras, List<string> sinonimos){    
        foreach(var i in palavras.Keys){
            Console.WriteLine(i);
        }
    }
}


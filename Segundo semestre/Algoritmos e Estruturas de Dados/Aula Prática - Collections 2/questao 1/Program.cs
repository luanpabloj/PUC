using System.IO;
using System.Reflection.Metadata;
namespace questao_1;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dicionario = new Dictionary<string, int>();
        StreamReader arq = new StreamReader("Aula Prática - Collections_Parte2.txt");

        string leitura = arq.ReadLine();

        string[] palavras = leitura.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        foreach(string i in palavras){
            string igualar = i.ToLower();

            if(dicionario.ContainsKey(igualar)){
                dicionario[igualar]++;
            }
            else{
                dicionario[igualar] = 1;
            }
        }

        int opcao = 0;
        do{

            Console.WriteLine("1 - Verificar se uma determinada palavra consta no dicionário\n2 - Dar a opção de se consultar quantas palavras distintas constam no dicionário\n3 - Imprimir todas as palavras e suas respectivas frequências de ocorrências\n4 - sair");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    Console.Write("Digite uma palavra: ");
                    string palavra = Console.ReadLine();
                    encontrar(dicionario, palavra);
                    break;

                case 2:
                    Console.WriteLine($"Tem {dicionario.Count} palavras distintas no dicionário");
                    break;
                
                case 3:
                    palavrasFrequencia(dicionario);
                    break;
            }

        }while(opcao != 4);
        
    }

    static void encontrar(Dictionary<string, int> dicionario, string palavra){

            if(dicionario.ContainsKey(palavra)){
                Console.WriteLine("A palavra digitada está contida no dicionário");
            }
            else{
                Console.WriteLine("Palavra não encontrada");
            }
    }

    static void palavrasFrequencia(Dictionary<string, int> dicionario){
        foreach(var i in dicionario){
            Console.WriteLine($"Palavra: {i.Key} frequência: {i.Value}");
        }
    }
}

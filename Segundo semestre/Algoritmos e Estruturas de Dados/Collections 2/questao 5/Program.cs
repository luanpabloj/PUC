namespace questao_5;
class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> filmes = new LinkedList<string>();

        int opcao = 0;

        do{
            Console.WriteLine("1 - Inserir um filme no final da lista\n2 - Inserir um filme depois de uma posição específica da lista\n3 - Inserir um filme antes de uma posição específica da lista\n4 - Remover o filme que estiver no final da lista\n5 - Pesquisar se um filme consta na lista\n6 - Listar todos os filmes da lista\n7 - Sair");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao){
                case 1:
                    inserirFilme(filmes);
                break;
                case 2:
                    inserirDepois(filmes);
                break;
                case 3:
                    inserirAntes(filmes);
                break;
                case 4:
                    removerFinal(filmes);
                break;
                case 5:
                    pesquisar(filmes);
                break;
                case 6:
                    listar(filmes);
                break;
            }
        } while (opcao != 7);
    }

    static void inserirFilme(LinkedList<string> filmes){
        Console.Write("Digite o nome do filme: ");
        string nomefilme = Console.ReadLine();

        filmes.AddLast(nomefilme);

        Console.WriteLine("Filme adicionado no final da lista");
    }

    static void inserirDepois(LinkedList<string> filmes){
        Console.Write("Digite o nome do filme: ");
        string nomefilme = Console.ReadLine();
        Console.Write("Digite o nome do filme depois do que você deseja inserir: ");
        string nomeAnterior = Console.ReadLine();

        LinkedListNode<string> node = filmes.Find(nomeAnterior);
        filmes.AddAfter(node, nomefilme);        
    }

    static void inserirAntes(LinkedList<string> filmes){
        Console.Write("Digite o nome do filme: ");
        string nomefilme = Console.ReadLine();
        Console.Write("Digite o nome do filme antes do que você deseja inserir: ");
        string nomePosterior = Console.ReadLine();

        LinkedListNode<string> node = filmes.Find(nomePosterior);

        filmes.AddBefore(node, nomefilme);        
    }

    static void removerFinal(LinkedList<string> filmes){
        filmes.RemoveLast();
        Console.WriteLine("Filme removido");
    }

    static void pesquisar(LinkedList<string> filmes){
        Console.Write("Digite o nome do filme: ");
        string nome = Console.ReadLine();

        if(filmes.Contains(nome) == true){
            Console.WriteLine("Filme encontrado");
        }
        else{
            Console.WriteLine("Filme não encontrado");
        }
    }

    static void listar(LinkedList<string> filmes){
        foreach(var i in filmes){
            Console.WriteLine(i);
        }
    }
}

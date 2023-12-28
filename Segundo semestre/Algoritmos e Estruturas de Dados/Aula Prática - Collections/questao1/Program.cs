namespace questao1;
using System.Collections.Generic;

class ListaFilmes{
    
    private List<string> filmes = new List<string>();


    public void inserirFilme(string x){
        filmes.Add(x);
        Console.WriteLine($"Filme {x} incluído na lista");
    }

    public void inserirPosicao(int y, string x){
        filmes.Insert(y, x);
        Console.WriteLine("Filme incluido na posição indicada");
    }

    public void removerFilme(string x){
        filmes.Remove(x);
        Console.WriteLine("Filme removido da lista");
    }

    public void removerFilmePosicao(int y){
        filmes.RemoveAt(y);
        Console.WriteLine("Filme removido da lista");
    }

    public void pesquisarFilme(string x){
        if(filmes.Contains(x) == false){
            Console.WriteLine("Filme não encontrado na lista");
        }
        else{
            Console.WriteLine("Filme já registrado na lista");
        }
    }

    public void listarFilmes(){
        foreach(string i in filmes){
            Console.WriteLine(i);
        }
    }

    public void ordenarLista(){
        filmes.Sort();
    }

    public void inverterLista(){
        filmes.Reverse();
    }


}
class Program
{
    static void Main(string[] args)
    {
        string x = "";
        int y = 0, opcao = 0;
        ListaFilmes filmes = new ListaFilmes();

        do{
            Console.WriteLine("1 - Inserir um filme no final da lista\n2 - Inserir um filme em uma posição específica da lista\n3 - Remover um filme da lista\n4 - Remover um filme em uma posição específica da lista\n5 - Pesquisar se um filme consta na lista\n6 - Listar todos os filmes da lista\n7 - Inverter a ordem dos filmes presentes na lista\n8 - Ordenar a lista de filmes\n9 - Encerrar o programa");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    Console.Write("Digite o nome do filme: ");
                    x = Console.ReadLine();
                    filmes.inserirFilme(x);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 2:
                    Console.Write("Digite a posição e o nome do filme a ser incluido na lista: ");
                    y = int.Parse(Console.ReadLine());
                    x = Console.ReadLine();
                    filmes.inserirPosicao(y, x);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 3:
                    Console.Write("Digite o nome do filme a ser removido da lista: ");
                    x = Console.ReadLine();
                    filmes.removerFilme(x);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 4:
                    Console.Write("Digite a posição do filme a ser excluido: ");
                    y = int.Parse(Console.ReadLine());
                    filmes.removerFilmePosicao(y);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 5:
                    Console.Write("Digite o nome do filme a ser verificado se está cadastrado na lista: ");
                    x = Console.ReadLine();
                    filmes.pesquisarFilme(x);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 6:
                    Console.WriteLine("Filmes cadastrados:");
                    filmes.listarFilmes();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 7:
                    filmes.inverterLista();
                    Console.WriteLine("Lista invertida");
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 8:
                    filmes.ordenarLista();
                    Console.WriteLine("Lista ordenada");
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                
            }   

        }while(opcao != 9);
        Console.WriteLine("Fim do programa");
    }
}

namespace questao_3;
class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> jogadores = new SortedList<int, string>();


        int opcao = 0;

        do{
            Console.WriteLine("1 - Adicionar um novo jogador e sua pontuação\n2 - Verificar a pontuação de um jogador em específico\n3 - Remover um jogador, bem como sua pontuação\n4 - Exibir o ranking de pontuação de forma crescente\n5 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    preencherList(jogadores);
                    break;
                case 2:
                    olharPontuacao(jogadores);
                    break;
                case 3:
                    remover(jogadores);
                    break;
                case 4:
                    ranking(jogadores);
                    break;

            }
        }while(opcao != 5);

    }

    static void preencherList(SortedList<int, string> jogadores){
        Console.Write("Digite o nome do jogador: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a pontuação do jogador: ");
        int pontuacao = int.Parse(Console.ReadLine());

        jogadores.Add(pontuacao, nome);
    }


    static void olharPontuacao(SortedList<int, string> jogadores){

        Console.Write("Digite o nome do jogador para verificar a sua pontuação: ");
        string nome = Console.ReadLine();

        foreach(var i in jogadores){
            if(i.Value == nome)
                Console.WriteLine("Jogador: " + i.Value + " Pontuação: " + i.Key);
        }
    }

    static void remover(SortedList<int, string> jogadores){
        Console.Write("Digite o nome do jogador a ser removido: ");
        string nome = Console.ReadLine();
        int auxiliar = 0;

        foreach(var i in jogadores){
            if(i.Value == nome){
                auxiliar = i.Key;
            }
        }

        jogadores.Remove(auxiliar);
    }

    static void ranking(SortedList<int, string> jogadores){

        foreach (var i in jogadores){
        Console.WriteLine($"Nome: {i.Value} Pontuação: {i.Key}");
        }
    }
}

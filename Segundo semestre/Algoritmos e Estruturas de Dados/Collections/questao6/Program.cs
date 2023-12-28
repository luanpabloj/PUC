namespace questao6;

class Cientifica{
    private Queue<int> filaCientifica = new Queue<int>();

    public void inserirCientifica(int codigo){
        filaCientifica.Enqueue(codigo);
        Console.WriteLine("Aluno incluido na fila iniciação científica.");
    }

    public void removerCientifica(int codigo){
            filaCientifica.Dequeue();
            Console.WriteLine("Aluno removido da lista iniciação científica");
    }

    public void mostrarCientifica(){
        int[] vetor = new int[filaCientifica.Count];

        vetor = filaCientifica.ToArray();

        Console.WriteLine("Código de todos os alunos da lista iniciação científica: ");
        for(int i = 0; i < vetor.Length; i++){
            Console.Write(vetor[i] + ", ");
        }
    }

    public void pesquisarCientifica(int codigo){
        if(filaCientifica.Contains(codigo) == true){
            Console.WriteLine("Código encontrado na lista iniciação científica");
        }
        else{
            Console.WriteLine("Código não encontrado na lista iniciação científica");
        }
    }

    public void primeiroCientifica(){
        Console.WriteLine("Primeiro da fila iniciação científica: " + filaCientifica.Peek());
    }

}

class Mestrado{
    private Queue<int> filaMestrado = new Queue<int>();

    public void inserirMestrado(int codigo){
        filaMestrado.Enqueue(codigo);
        Console.WriteLine("Aluno incluido na fila mestrado.");
    }

    public void removerMestrado(int codigo){
        filaMestrado.Dequeue();
        Console.WriteLine("Aluno removido da lista mestrado");
    }

    public void mostrarMestrado(){
        int[] vetor = new int[filaMestrado.Count];

       vetor = filaMestrado.ToArray();

        Console.WriteLine("Código de todos os alunos da lista mestrado: ");
        for(int i = 0; i < vetor.Length; i++){
            Console.Write(vetor[i] + ", ");
        }
    }

    public void pesquisarMestrado(int codigo){
        if(filaMestrado.Contains(codigo) == true){
            Console.WriteLine("Código encontrado na lista mestrado");
        }
        else{
            Console.WriteLine("Código não encontrado na lista mestrado");
        }
    }

    public void primeiroMestrado(){
        Console.WriteLine("Primeiro da fila mestrado: " + filaMestrado.Peek());
    }


}


class Program
{
    static void Main(string[] args)
    {
        int codigo = 0, opcao = 0;
        Mestrado mestrado = new Mestrado();
        Cientifica cientifica = new Cientifica();

        do{
            Console.WriteLine("1 - Inserir um aluno na fila de espera de bolsas de Iniciação Científica\n2 - Inserir um aluno na fila de espera de bolsas de Mestrado\n3 - Remover um aluno da fila de bolsas de Iniciação Científica\n4 - Remover um aluno da fila de bolsas de Mestrado\n5 - Mostrar fila de espera de bolsas de Iniciação Científica\n6 - Mostrar fila de espera de bolsas de Mestrado\n7 - Pesquisar aluno na fila de espera de bolsas de Iniciação Científica\n8 - Pesquisar aluno na fila de espera de bolsas de Mestrado\n9 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Iniciação Científica\n10 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Mestrado\n11- Encerrar o programa");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao){

                case 1:
                Console.Write("Digite o código do aluno: ");
                codigo = int.Parse(Console.ReadLine());
                cientifica.inserirCientifica(codigo);
                Console.WriteLine(" ");
                break;

                case 2:
                Console.Write("Digite o código do aluno: ");
                codigo = int.Parse(Console.ReadLine());
                mestrado.inserirMestrado(codigo);
                Console.WriteLine(" ");
                break;

                case 3:
                codigo = int.Parse(Console.ReadLine());
                cientifica.removerCientifica(codigo);
                Console.WriteLine(" ");
                break;

                case 4:
                codigo = int.Parse(Console.ReadLine());
                mestrado.removerMestrado(codigo);
                Console.WriteLine(" ");
                break;

                case 5:
                cientifica.mostrarCientifica();
                Console.WriteLine(" ");            
                break;

                case 6:
                mestrado.mostrarMestrado();
                Console.WriteLine(" ");
                break;

                case 7:
                Console.Write("Digite o código do aluno a ser encontrado: ");
                codigo = int.Parse(Console.ReadLine());
                cientifica.pesquisarCientifica(codigo);
                break;

                case 8:
                Console.Write("Digite o código do aluno a ser encontrado: ");
                codigo = int.Parse(Console.ReadLine());
                mestrado.pesquisarMestrado(codigo);
                break;

                case 9:
                cientifica.primeiroCientifica();
                Console.WriteLine(" ");
                break;

                case 10:
                mestrado.primeiroMestrado();
                Console.WriteLine(" ");
                break;


            }
        }while(opcao != 11);


    }
}

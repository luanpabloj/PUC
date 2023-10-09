namespace questao7;

class Fila{
    private Queue<string> cliente = new Queue<string>();

    public void adicionar(string nome){
        cliente.Enqueue(nome);
        Console.WriteLine("Cliente adicionado na fila");
        Console.WriteLine(" ");
    }

    public void atender(){
        cliente.Dequeue();
        Console.WriteLine("Cliente atendido");
        Console.WriteLine(" ");
    }

    public void fila(){
        Console.WriteLine(cliente.Count() + " clientes na fila");
        Console.WriteLine(" ");        
    }

    public void primeiro(){
        Console.WriteLine("Próximo a ser atendido: " + cliente.Peek());
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nome = "";
        int opcao = 0;
        Fila fila = new Fila();

        do{
            Console.WriteLine("1) Adicionar um cliente à fila\n2) Atender um cliente (remover o primeiro da fila)\n3) Exibir o número de clientes na fila\n4) Exibir o próximo cliente a ser atendido\n5) Sair do programa");

            opcao = int.Parse(Console.ReadLine());
            
            switch(opcao){
                case 1:
                Console.Write("Digite o nome do cliente: ");
                nome = Console.ReadLine();
                fila.adicionar(nome);
                break;

                case 2:
                fila.atender();
                break;

                case 3:
                fila.fila();
                break;

                case 4:
                fila.primeiro();
                break;
            }
        }while(opcao != 5);
    }
}

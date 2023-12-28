namespace questao6;

class Fila {
    private string[] array;
    private int primeiro, ultimo, cont;
    
    public Fila () {inicializar(5);}
    
    public Fila (int tamanho) {
        inicializar(tamanho);
    }
    public void inicializar(int tamanho){
        array = new string[tamanho+1];
        primeiro = ultimo = 0;  
    } 
    public void inserir(string x) {
        if (((ultimo + 1) % array.Length) == primeiro)
            throw new Exception("Erro!");
        
        array[ultimo] = x;
        ultimo = (ultimo + 1) % array.Length;
        cont = cont + 1;
    }
    public string remover() { 
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        
        string resp = array[primeiro];
        primeiro = (primeiro + 1) % array.Length;
        cont = cont - 1;
        return resp;
    }
    public void mostrar() { 
        int i = primeiro;  
        Console.Write("[");
        while(i!=ultimo){
            Console.Write(array[i] + " ");  
            i = (i + 1) % array.Length;
        }
        Console.WriteLine("]");
    }
    
    public void contar(){

        Console.WriteLine(cont + " clientes na fila");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int opcao = 0;
        Fila fila = new Fila();

        do{
            Console.WriteLine("1 - Adicionar um cliente à fila\n2 - Atender um cliente (remover o primeiro da fila)\n3 - Exibir o número de clientes na fila\n4 - Exibir o próximo cliente a ser atendido\n5 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao){

                case 1:
                Console.Write("Digite o nome do cliente: ");
                string x = Console.ReadLine();
                fila.inserir(x);
                Console.WriteLine(" ");
                break;

                case 2:
                fila.remover();
                Console.WriteLine("Cliente atendido");
                Console.WriteLine(" ");
                break;

                case 3:
                fila.contar();
                Console.WriteLine(" ");
                break;

                case 4:
                fila.mostrar();
                Console.WriteLine(" ");
                break;

                
            }
        }while(opcao != 5);


    }
}

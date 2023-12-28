namespace questao6;

class Fila {
    private int[] array;
    private int primeiro, ultimo;
    
    public Fila () {inicializar(5);}
    
    public Fila (int tamanho) {
        inicializar(tamanho);
    }
    public void inicializar(int tamanho){
        array = new int[tamanho+1];
        primeiro = ultimo = 0;  
    } 
    public void inserir(int codigo) {
        if (((ultimo + 1) % array.Length) == primeiro)
            throw new Exception("Erro!");
        
        array[ultimo] = codigo;
        ultimo = (ultimo + 1) % array.Length;
    }
    public int remover() { 
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        
        int resp = array[primeiro];
        primeiro = (primeiro + 1) % array.Length;
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

    public void pesquisar(int codigo){
        for(int i = 0; i < array.Length; i++){
            if(array[i] == codigo){
                Console.WriteLine("Aluno encontrado");
                break;
            }
            else{
                Console.WriteLine("Aluno não encontrado");
                break;
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        int codigo = 0, opcao = 0;
        Fila mestrado = new Fila();
        Fila cientifica = new Fila();

        do{
            Console.WriteLine("1 - Inserir um aluno na fila de espera de bolsas de Iniciação Científica\n2 - Inserir um aluno na fila de espera de bolsas de Mestrado\n3 - Remover um aluno da fila de bolsas de Iniciação Científica\n4 - Remover um aluno da fila de bolsas de Mestrado\n5 - Mostrar fila de espera de bolsas de Iniciação Científica\n6 - Mostrar fila de espera de bolsas de Mestrado\n7 - Pesquisar aluno na fila de espera de bolsas de Iniciação Científica\n8 - Pesquisar aluno na fila de espera de bolsas de Mestrado\n9 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Iniciação Científica\n10 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Mestrado\n11- Encerrar o programa");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao){

                case 1:
                Console.Write("Digite o código do aluno: ");
                codigo = int.Parse(Console.ReadLine());
                cientifica.inserir(codigo);
                Console.WriteLine(" ");
                break;

                case 2:
                Console.Write("Digite o código do aluno: ");
                codigo = int.Parse(Console.ReadLine());
                mestrado.inserir(codigo);
                Console.WriteLine(" ");
                break;

                case 3:
                codigo = int.Parse(Console.ReadLine());
                cientifica.remover();
                Console.WriteLine(" ");
                break;

                case 4:
                codigo = int.Parse(Console.ReadLine());
                mestrado.remover();
                Console.WriteLine(" ");
                break;

                case 5:
                cientifica.mostrar();
                Console.WriteLine(" ");            
                break;

                case 6:
                mestrado.mostrar();
                Console.WriteLine(" ");
                break;

                case 7:
                Console.Write("Digite o código do aluno a ser encontrado: ");
                codigo = int.Parse(Console.ReadLine());
                cientifica.pesquisar(codigo);
                break;

                case 8:
                Console.Write("Digite o código do aluno a ser encontrado: ");
                codigo = int.Parse(Console.ReadLine());
                mestrado.pesquisar(codigo);
                break;

                case 9:
                cientifica.mostrar();
                Console.WriteLine(" ");
                break;

                case 10:
                mestrado.mostrar();
                Console.WriteLine(" ");
                break;


            }
        }while(opcao != 11);


    }
}

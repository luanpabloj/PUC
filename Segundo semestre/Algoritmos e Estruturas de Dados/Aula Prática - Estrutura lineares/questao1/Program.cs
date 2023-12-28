namespace questao1;
using System.Collections.Generic;

class Lista {

    private string[] array;
    private int n;
    
    public Lista (){
    
        Inicializar(0);
    }
    public Lista (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new string[tamanho];
        this.n = 0;
    }
    
    public void inserirInicio(string x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > 0; i--){
            array[i] = array[i-1];
        }
        array[0] = x;
        n++;
    }
    
    public void inserirFim(string x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        array[n] = x;
        n++;
    }
    
    public void inserir(string x, int pos) {
        if (n >= array.Length || pos < 0 || pos > n)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > pos; i--){
            array[i] = array[i-1];
        }
        array[pos] = x;
        n++;
    }
    
    public string removerInicio() {
        if (n == 0)
            throw new Exception("Erro!");
        string resp = array[0];
        n--;
        for (int i = 0; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public string removerFim() {
        if (n == 0)
            throw new Exception("Erro!");
        n = n-1;
        return array[n];
    }
    
    public string remover(int pos) {
        if (n == 0 || pos < 0 || pos >= n)
            throw new Exception("Erro!");
        string resp = array[pos];
        n--;
        for (int i = pos; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public void mostrar (){
        Console.Write("[ ");
        for (int i = 0; i < n; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }

    public void verificar(string x){
        for(int i = 0; i < n; i++){
            if(array[i] == x){
                Console.WriteLine("Filme encontrado na lista");
            }
            else{
                Console.WriteLine("Filme não encontrado");
            }
        }
    }

    public void inverter(){
         for (int i = 0; i < n / 2; i++){
                string temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }
    }
}
class Program
{
    static void Main(string[] args)
    {
        string x = "";
        int y = 0, opcao = 0, pos = 0;
        Lista lista = new Lista(6);

        do{
            Console.WriteLine("1 - Inserir um filme no final da lista\n2 - Inserir um filme em uma posição específica da lista\n3 - Remover um filme da lista\n4 - Remover um filme em uma posição específica da lista\n5 - Pesquisar se um filme consta na lista\n6 - Listar todos os filmes da lista\n7 - Inverter a ordem dos filmes presentes na lista\n8 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    Console.Write("Digite o nome do filme: ");
                    x = Console.ReadLine();
                    lista.inserirFim(x);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 2:
                    Console.Write("Digite a posição e o nome do filme a ser incluido na lista: ");
                    y = int.Parse(Console.ReadLine());
                    x = Console.ReadLine();
                    lista.inserir(x, y);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 3:
                    lista.removerFim();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 4:
                    Console.Write("Digite a posição do filme a ser excluido: ");
                    pos = int.Parse(Console.ReadLine());
                    lista.remover(pos);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 5:
                    Console.Write("Digite o nome do filme a ser verificado se está cadastrado na lista: ");
                    x = Console.ReadLine(); 
                    lista.verificar(x);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 6:
                    Console.WriteLine("Filmes cadastrados:");
                    lista.mostrar();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                case 7:
                    lista.inverter();
                    Console.WriteLine("Lista invertida");
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                    break;
                
            }   

        }while(opcao != 8);
        Console.WriteLine("Fim do programa");
    }
}

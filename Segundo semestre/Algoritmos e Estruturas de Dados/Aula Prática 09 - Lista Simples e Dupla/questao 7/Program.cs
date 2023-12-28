using System;
using System.Numerics;

class Contato{
    private string nome;
    private string email;
    private int numero;

    public Contato(string nome, string email, int numero){
        this.nome = nome;
        this.email = email;
        this.numero = numero;
    }

    public string Nome{
        get {return nome; }
        set {nome = value; }
    }

    public string Email{
        get {return email; }
        set {email = value; }
    }

    public int Numero{
        get {return numero; }
        set {numero = value; }
    }


}

class Lista {
    private Contato[] array;
    private int n;
    
    public Lista (){
    
        Inicializar(5);
    }
    public Lista (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new Contato[tamanho];
        this.n = 0;
    }
    
    public void inserirInicio(Contato x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > 0; i--){
            array[i] = array[i-1];
        }
        array[0] = x;
        n++;
    }
    
    public void inserirFim(Contato x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        array[n] = x;
        n++;
    }
    
    public void inserir(Contato x, int pos) {
        if (n >= array.Length || pos < 0 || pos > n)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > pos; i--){
            array[i] = array[i-1];
        }
        array[pos] = x;
        n++;
    }
    
    public Contato removerInicio() {
        if (n == 0)
            throw new Exception("Erro!");
        Contato resp = array[0];
        n--;
        for (int i = 0; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public Contato removerFim() {
        if (n == 0)
            throw new Exception("Erro!");
        n = n-1;
        return array[n];
    }
    
    public Contato remover(int pos) {
        if (n == 0 || pos < 0 || pos >= n)
            throw new Exception("Erro!");
        Contato resp = array[pos];
        n--;
        for (int i = pos; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public void mostrar (){
        Console.Write("[ ");
        for (int i = 0; i < n; i++){
            Console.WriteLine("Nome: " + array[i].Nome + ", Email: " + array[i].Email + ", Número: " + array[i].Numero);
        }
        Console.WriteLine(" ]");
    }

    public void Atualizar(string nome, string email, int numero){
        for(int i = 0; i < 5; i++){
            if(array[i].Nome == nome){
                array[i].Email = email;
                array[i].Numero = numero;
                Console.WriteLine("Contato atualizado");
                break;
            }
        }
    }

}

class Program {

    static void Main() {
        Lista lista = new Lista();
        Contato contato;
        int opcao = 0;

        do{

            Console.WriteLine("Digite:\n1 - Adicionar contato\n2 - Atualizar contato\n3 - Excluir contato\n4 - Listar todos os contatos\n5 - Sair");

            opcao = int.Parse(Console.ReadLine());

        switch(opcao){
            case 1:
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine();
            Console.Write("Digite o número do contato: ");
            int numero = int.Parse(Console.ReadLine());
            contato = new Contato(nome, email, numero);
            lista.inserirFim(contato);
            break;

            case 2:
            Console.Write("Digite o nome do contato a ser atualizado: ");
            string nomee = Console.ReadLine();
            Console.Write("Digite o email atualizado: ");
            string emaill = Console.ReadLine();
            Console.Write("Digite o número atualizado: ");
            int numeroo = int.Parse(Console.ReadLine());
            lista.Atualizar(nomee, emaill, numeroo);
            break;
            
            case 3:
            lista.removerInicio();
            Console.WriteLine("O primeiro contato da lista foi excluido");
            break;

            case 4:
            lista.mostrar();
            break;

        }
        }while(opcao != 5);
    }

}

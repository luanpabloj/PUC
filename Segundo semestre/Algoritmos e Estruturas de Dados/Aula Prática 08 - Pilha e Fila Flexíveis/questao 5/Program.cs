namespace questao_5;

class Celula
{
    private int elemento;
    private Celula prox;

    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = 0;
        this.prox = null;
    }

    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

}

class Fila {
    private Celula primeiro, ultimo;
    
    public Fila () {
        primeiro = new Celula();  
        ultimo = primeiro;
    }
    
    public void Inserir(int x) { 
        ultimo.Prox = new Celula(x);  
        ultimo = ultimo.Prox;
    }
    
    public int Remover(){
        if (primeiro == ultimo)
            throw new Exception("Erro!");  
        Celula tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;  
        tmp.Prox = null;
        tmp = null;  
        return elemento;
    }
    
    public void Mostrar() {
        Console.Write("[");
        for (Celula i = primeiro.Prox; i != null; i = i.Prox) 
        {     	
        	Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }
}

class Pilha {
    private Celula topo;
    public Pilha () {
        topo = null;
    }
    
    public void Inserir(int x) {  
        Celula tmp = new Celula(x);  
        tmp.Prox = topo;
        topo = tmp;  
        tmp = null;
    }
    
    public int Remover()  {
        if (topo == null)
            throw new Exception("Erro!");  
        int elemento = topo.Elemento;  
        Celula tmp = topo;
        topo = topo.Prox;  
        tmp.Prox = null;  
        tmp = null;  
        return elemento;
    }
    
    public void Mostrar() {  
        Console.Write("[ ");
        for (Celula i = topo; i != null; i = i.Prox){
             Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Pilha pilha = new Pilha();
        Fila fila = new Fila();

        preencherfila(fila);
        inverterFila(fila, pilha);
    }

    static void preencherfila(Fila fila){
        Console.WriteLine("Digite 5 números para a fila");
        for(int i = 0; i < 5; i++){
            int x = int.Parse(Console.ReadLine());
            fila.Inserir(x);
        }
    }

    static void inverterFila(Fila fila, Pilha pilha){
        for(int i = 0; i < 5; i++){
            pilha.Inserir(fila.Remover());
        }

        for(int i = 0; i < 5; i++){
            fila.Inserir(pilha.Remover());
        }

        fila.Mostrar();
    }
}

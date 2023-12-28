namespace questao_1;

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
        preencherPilha(pilha);
        inverter(pilha);
    }

    static void preencherPilha(Pilha pilha){

        for(int i = 0; i < 5; i++){
            int x = int.Parse(Console.ReadLine());
            pilha.Inserir(x);
        }

    }

    static void inverter(Pilha pilha){
        Pilha pilha1 = new Pilha();

        for(int i = 0; i < 5; i++){
            int x = pilha.Remover();
            pilha1.Inserir(x);
        }
        
        pilha1.Mostrar();
        
    }
    
}

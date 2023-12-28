using System;
namespace questao_2;


class Celula
{
    private char elemento;
    private Celula prox;

    public Celula(char elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = '\0';
        this.prox = null;
    }

    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public char Elemento
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
    
    public void Inserir(char x) {  
        Celula tmp = new Celula(x);  
        tmp.Prox = topo;
        topo = tmp;  
        tmp = null;
    }
    
    public char  Remover()  {
        if (topo == null)
            throw new Exception("Erro!");  
        char elemento = topo.Elemento;  
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
        Pilha p = new Pilha();
        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine();
        Pilha aux = new Pilha();
        entrada(p, palavra, aux);
        comparar(p, aux, palavra);
    }

    static void entrada(Pilha p, string palavra, Pilha aux){
        char[] chars = palavra.ToCharArray();
        var palavrainvertida = new string(palavra.Reverse().ToArray());

        foreach(var i in chars){
            p.Inserir(i);
        }
        char[] chars2 = palavrainvertida.ToCharArray();

        foreach(var i in chars2){
            aux.Inserir(i);
        }
    }

    static void comparar(Pilha p, Pilha aux, string palavra){
        bool trueFalse = true;

        for(int i = 0; i < palavra.Length; i++){
            if(p.Remover() != aux.Remover()){
                trueFalse = false;
            }
        }


        if(trueFalse == true){
            Console.WriteLine("A palavra digitada é palíndromo");
        }
        else{
            Console.WriteLine("A palavra digitada não é palíndromo");
        }
    }

}

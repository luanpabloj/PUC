using System;
using System.Numerics;

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


class Program {
    static void Main() {
        Fila fila1 = new Fila();
        Fila fila2 = new Fila();

        preencherFilas(fila1, fila2);
        preencherFila1(fila1, fila2);

   }

   static void preencherFilas(Fila fila1, Fila fila2){
    Console.WriteLine("Digite 5 valores para a fila 1");
        for(int i = 0; i < 5; i++){
            int x = int.Parse(Console.ReadLine());
            fila1.Inserir(x);
        }

    Console.WriteLine("Digite 5 valores para a fila 2");
        for(int i = 0; i < 5; i++){
            int x = int.Parse(Console.ReadLine());
            fila2.Inserir(x);
        }
    }
   

   static void preencherFila1(Fila fila1, Fila fila2){
        for(int i = 0; i < 5; i++){
            fila1.Inserir(fila2.Remover());
        }
        fila1.Mostrar();
   }
}


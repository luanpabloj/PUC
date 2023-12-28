using System;
using System.Numerics;

class Lista {

    private int[] array;
    private int n;
    
    public Lista (){
    
        Inicializar(5);
    }
    public Lista (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new int[tamanho];
        this.n = 0;
    }
    
    public void inserirInicio(int x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > 0; i--){
            array[i] = array[i-1];
        }
        array[0] = x;
        n++;
    }
    
    public void inserirFim(int x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        array[n] = x;
        n++;
    }
    
    public void inserir(int x, int pos) {
        if (n >= array.Length || pos < 0 || pos > n)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > pos; i--){
            array[i] = array[i-1];
        }
        array[pos] = x;
        n++;
    }
    
    public int removerInicio() {
        if (n == 0)
            throw new Exception("Erro!");
        int resp = array[0];
        n--;
        for (int i = 0; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public int removerFim() {
        if (n == 0)
            throw new Exception("Erro!");
        n = n-1;
        return array[n];
    }
    
    public int remover(int pos) {
        if (n == 0 || pos < 0 || pos >= n)
            throw new Exception("Erro!");
        int resp = array[pos];
        n--;
        for (int i = pos; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }

    public bool verificar(){
        int aux = 0, cont = 0;
        bool x = false;

        for(int i = 0; i < array.Length; i++){
            aux = array[0];
            if(aux < array[i]){
                aux = array[i];
            }
            x = true;
            cont++;
        }
        return x;
    }

}

class CelulaDupla
{
    private int elemento;
    private CelulaDupla prox, ant;

    public CelulaDupla(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
        this.ant = null;
    }

    public CelulaDupla()
    {
        this.elemento = 0;
        this.prox = null;
        this.ant = null;
    }

    public CelulaDupla Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    
    public CelulaDupla Ant
    {
        get { return ant; }
        set { ant = value; }
    }

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

}

class ListaDupla {
    private CelulaDupla primeiro, ultimo;
    public ListaDupla () {
        primeiro = new CelulaDupla();  
        ultimo = primeiro;
    }
    
    public void InserirInicio(int x) {
        CelulaDupla tmp = new CelulaDupla(x);
        tmp.Ant = primeiro;  
        tmp.Prox = primeiro.Prox;  
        primeiro.Prox = tmp;
        if (primeiro == ultimo) {  
            ultimo = tmp;
        }
        else {
            tmp.Prox.Ant = tmp;
        }
        tmp = null;
    }
    
    public void InserirFim(int x) {  
        ultimo.Prox = new CelulaDupla(x);  
        ultimo.Prox.Ant = ultimo;
        ultimo = ultimo.Prox;
    }
    
    public int RemoverInicio() {
        if (primeiro == ultimo)
            throw new Exception("Erro!");  
        CelulaDupla tmp = primeiro;  
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;  
        tmp.Prox = primeiro.Ant = null;  
        tmp = null;
        return elemento;
    }
    
    public int RemoverFim() {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        
        int elemento = ultimo.Elemento;  
        ultimo = ultimo.Ant;  
        ultimo.Prox.Ant = null;  
        ultimo.Prox = null;
        return elemento;
    }
    
    public int Tamanho() {
        int tam = 0; 
        for (CelulaDupla i = primeiro; i != ultimo; i = i.Prox)
        {
            tam++;
        }
        
        return tam;
    }
    
    
    public void Inserir(int x, int pos) {
        int tamanho = Tamanho();
        if (pos < 0 || pos > tamanho){
            throw new Exception("Erro!");
        } 
        else if (pos == 0){ 
            InserirInicio(x);
        } 
        else if (pos == tamanho){ 
            InserirFim(x);
        } 
        else {
            CelulaDupla i = primeiro;
            for (int j = 0; j < pos; j++, i = i.Prox);
            
            CelulaDupla tmp = new CelulaDupla(x);
            tmp.Ant = i;
            tmp.Prox = i.Prox;
            tmp.Ant.Prox = tmp.Prox.Ant = tmp;
            tmp = i = null;
        }
    }
    
    public int Remover(int pos) {
        int elemento, tamanho = Tamanho();
        if (primeiro == ultimo){
            throw new Exception("Erro!");
        } 
        else if (pos < 0 || pos >= tamanho){
            throw new Exception("Erro!");
        } 
        else if (pos == 0){
            elemento = RemoverInicio();
        } 
        else if (pos == tamanho - 1){  
            elemento = RemoverFim();
        } 
        else {
            CelulaDupla i = primeiro.Prox;
            for (int j = 0; j < pos; j++, i = i.Prox);
            i.Ant.Prox = i.Prox;  
            i.Prox.Ant = i.Ant;  
            elemento = i.Elemento;  
            i.Prox = i.Ant = null;
            i = null;
        }
        return elemento;
    }
    
    public void Mostrar() {
        Console.Write("[");
        for (CelulaDupla i = primeiro.Prox; i != null; i = i.Prox) 
        {     	
        	Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    } 

    public bool verificar(){
        int aux = 0;
        bool x = false;

        for(CelulaDupla i = primeiro; i != null; i = i.Prox){
            aux = i.Elemento;
            if(aux < i.Elemento){
                aux = i.Elemento;
            }
            x = true;
        }

        return x;
    }
}

class Program {

    static void Main() {
        
        Lista lista = new Lista();
        ListaDupla lista2 = new ListaDupla();

        Console.WriteLine("Digite 5 números: ");
        for(int i = 0; i < 5; i++){
            int x = int.Parse(Console.ReadLine());
            lista.inserirInicio(x);
        }

        Console.WriteLine("Lista simples: " + lista.verificar());
        Console.WriteLine("Lista dupla: " + lista2.verificar());

    }

}

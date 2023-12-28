using System;
using System.Numerics;

class Lista {

    private int[] array;
    private int n;
    
    public Lista (){
    
        Inicializar(10);

    }
    public Lista (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new int[tamanho];
        this.n = 0;
    }
    
    public void inserirInicio(int x) {
        if (n >= 10)
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


    
    public void mostrar (){
        Console.Write("[ ");
        for (int i = 0; i < 10; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }


    public void Juntar(int[] vect){

        for(int i = 0; i < 10; i++){
            int x = vect[i];
            inserirInicio(x);
        }
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
    private CelulaDupla primeiro2, ultimo2;

 public ListaDupla () {
        primeiro = new CelulaDupla();  
        ultimo = primeiro;
        primeiro2 = new CelulaDupla();  
        ultimo2 = primeiro2;
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
    
    public void InserirInicio2(int x) {
        CelulaDupla tmp = new CelulaDupla(x);
        tmp.Ant = primeiro2;  
        tmp.Prox = primeiro2.Prox;  
        primeiro2.Prox = tmp;
        if (primeiro2 == ultimo2) {  
            ultimo2 = tmp;
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

    public void InserirFim2(int x) {  
        ultimo2.Prox = new CelulaDupla(x);  
        ultimo2.Prox.Ant = ultimo2;
        ultimo2 = ultimo2.Prox;
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

    public int RemoverInicio2() {
        if (primeiro2 == ultimo2)
            throw new Exception("Erro!");  
        CelulaDupla tmp = primeiro2;  
        primeiro2 = primeiro2.Prox;
        int elemento = primeiro2.Elemento;  
        tmp.Prox = primeiro2.Ant = null;  
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

    public int RemoverFim2() {
        if (primeiro2 == ultimo2)
            throw new Exception("Erro!");
        
        int elemento = ultimo2.Elemento;  
        ultimo2 = ultimo2.Ant;  
        ultimo2.Prox.Ant = null;  
        ultimo2.Prox = null;
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
    
    public int Tamanho2() {
        int tam = 0; 
        for (CelulaDupla i = primeiro2; i != ultimo2; i = i.Prox)
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

    public void Inserir2(int x, int pos) {
        int tamanho = Tamanho2();
        if (pos < 0 || pos > tamanho){
            throw new Exception("Erro!");
        } 
        else if (pos == 0){ 
            InserirInicio2(x);
        } 
        else if (pos == tamanho){ 
            InserirFim2(x);
        } 
        else {
            CelulaDupla i = primeiro2;
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

    public int Remover2(int pos) {
        int elemento, tamanho = Tamanho2();
        if (primeiro2 == ultimo2){
            throw new Exception("Erro!");
        } 
        else if (pos < 0 || pos >= tamanho){
            throw new Exception("Erro!");
        } 
        else if (pos == 0){
            elemento = RemoverInicio2();
        } 
        else if (pos == tamanho - 1){  
            elemento = RemoverFim2();
        } 
        else {
            CelulaDupla i = primeiro2.Prox;
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

    public void Mostrar2() {
        Console.Write("[");
        for (CelulaDupla i = primeiro2.Prox; i != null; i = i.Prox) 
        {     	
        	Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    } 

    public void juntarCadeado(){
        
        int x = 0;

         x = RemoverInicio2();
    
        CelulaDupla tmp = new CelulaDupla(x);

        tmp.Prox = primeiro.Prox;
        primeiro.Prox = tmp;
        tmp = null;
    }
}

class Program {

    static void Main() {

        ListaDupla listaDupla = new ListaDupla();
        Lista lista = new Lista();
        int[] vect = new int[10];
        
        Console.WriteLine("Digite os números para a lista 1");
        for(int i = 0; i < 5; i++){
            int num = int.Parse(Console.ReadLine());
            listaDupla.InserirInicio(num);
            vect[i] = num;
        }

        Console.WriteLine("Digite os números para a lista 2");
        for(int i = 5; i < 10; i++){
            int num = int.Parse(Console.ReadLine());
            listaDupla.InserirInicio2(num);
            vect[i] = num;
        }

        lista.Juntar(vect);
        Console.Write("Lista simples: ");
        lista.mostrar();

        for(int i = 0; i < 5; i++){
        listaDupla.juntarCadeado();
        }
        Console.Write("Lista dupla: ");
        listaDupla.Mostrar();

    }

}

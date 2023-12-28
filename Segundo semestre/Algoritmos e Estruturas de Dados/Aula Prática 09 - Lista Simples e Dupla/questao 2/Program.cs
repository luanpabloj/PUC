﻿using System;

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

    public void Inverter(){

        int teste = 0;
        ListaDupla lista = new ListaDupla();

        for(CelulaDupla i = primeiro.Prox; i != null; i = i.Prox){
            teste = i.Elemento;
            lista.InserirInicio(teste);
        }

        for(CelulaDupla i = primeiro.Prox; i != null; i = i.Prox){
            i.Elemento = lista.RemoverInicio();
        }
    }
}

class Program {

    static void Main() {

        ListaDupla lista = new ListaDupla();

        for(int i = 0; i < 5; i++){
            int num = int.Parse(Console.ReadLine());
            lista.InserirInicio(num);
        }
        lista.Inverter();
        lista.Mostrar();
    }

}


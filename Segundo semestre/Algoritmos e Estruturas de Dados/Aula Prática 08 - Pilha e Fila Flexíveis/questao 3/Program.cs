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
      Fila fila3 = new Fila();

      preencherFila1(fila1);
      preencherFila2(fila2);
      preencherFila3(fila1, fila2, fila3);

   }

   static void preencherFila1(Fila fila1){
      int[] vect = new int[5];
      Console.WriteLine("Digite 5 números para preencher a fila 1");
      
      for(int i = 0; i < 5; i++){
         int x = int.Parse(Console.ReadLine());
         vect[i] = x;
      }

      for(int i = 0; i < 5; i++){
         for(int j = 0; j < 5; j++){
            if(vect[i] < vect[j]){
               int auxiliar = vect[i];
               vect[i] = vect[j];
               vect[j] = auxiliar;
            }
         }
      }

      for(int i = 0; i < 5; i++){
         fila1.Inserir(vect[i]);
      }
   }


    static void preencherFila2(Fila fila2){
      int[] vect = new int[5];
      Console.WriteLine("Digite 5 números para preencher a fila 2");
      
      for(int i = 0; i < 5; i++){
         int x = int.Parse(Console.ReadLine());
         vect[i] = x;
      }

      for(int i = 0; i < 5; i++){
         for(int j = 0; j < 5; j++){
            if(vect[i] < vect[j]){
               int auxiliar = vect[i];
               vect[i] = vect[j];
               vect[j] = auxiliar;
            }
         }
      }

      for(int i = 0; i < 5; i++){
         fila2.Inserir(vect[i]);
      }
   }


    static void preencherFila3(Fila fila1, Fila fila2, Fila fila3){
         int[] vect = new int[10];

         for(int i = 0; i < 10; i++){
            if(i < 5){
            vect[i] = fila1.Remover();
            }
            else if(i > 5){
               vect[i] = fila2.Remover();
            }
         }

          for(int i = 0; i < 10; i++){
             for(int j = 0; j < 10; j++){
                if(vect[i] < vect[j]){
                int auxiliar = vect[i];
                vect[i] = vect[j];
                vect[j] = auxiliar;
            }
         }
      }

         for(int i = 0; i < 10; i++){
            fila3.Inserir(vect[i]);
         }

         fila3.Mostrar();
    }
}


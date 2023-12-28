namespace questao3;
using System.Collections.Generic;

class Pilha {

    private int[] array;
    private int topo;
    
    public Pilha (){
    
        Inicializar(12);
    }
    public Pilha (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new int[tamanho];
        this.topo = 0;
    }
    
    
    public void push(int x) {
        if (topo >= array.Length)
            throw new Exception("Erro!");
        array[topo] = x;
        topo++;
    }
    
    
    public int pop() {
        if (topo == 0)
            throw new Exception("Erro!");
        topo = topo-1;
        return array[topo];
    }
    
    public void mostrar() {
        Console.Write("[ ");
        for (int i = 0; i < topo; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }
    
}



class Program
{
    static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());

        Pilha pilha = new Pilha(n);

        for(int i = n - 1; i >= 0; i--){
            int x = recursao(i);
            pilha.push(x);
        }

        pilha.mostrar();

    }

    static int recursao(int n){
        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else{
            return recursao(n - 1) + recursao(n - 2);
        }
    }
}

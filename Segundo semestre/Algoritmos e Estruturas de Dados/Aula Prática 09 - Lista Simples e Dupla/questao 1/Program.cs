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
    
    public void mostrar (){
        Console.Write("[ ");
        for (int i = 0; i < n; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }

}

class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        inverter(lista);

    }

    static void inverter(Lista lista){
        int[] vect = new int[5];

        Console.WriteLine("Digite 5 números: ");

        for(int i = 0; i < 5; i++){
             int num = int.Parse(Console.ReadLine());
             lista.inserirInicio(num);
        }

        for(int i = 0; i < 5; i++){
            vect[i] = lista.removerFim();
        }

        for(int i = 0; i < 5; i++){
            lista.inserirInicio(vect[i]);
        }


        lista.mostrar();
    }


}

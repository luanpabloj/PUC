namespace questao5;

class Pilha {

    private char[] array;
    private int topo;
    
    public Pilha (string frase){
    
        Inicializar(frase.Length);
    }
    public Pilha (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new char[tamanho];
        this.topo = 0;
    }
    
    
    public void push(char x) {
        if (topo >= array.Length)
            throw new Exception("Erro!");
        array[topo] = x;
        topo++;
    }
    
    
    public char pop() {
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


        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        inverter(frase);

    }

    static void inverter(string frase){

        Pilha pilha = new Pilha(frase.Length);
        string mensagem = "";

        foreach(char i in frase){
            pilha.push(i);
        }

        char[] auxiliar = new char[frase.Length];
        for(int i = 0; i < frase.Length; i++){
            auxiliar[i] = pilha.pop();
        }

        foreach(char i in auxiliar){
            mensagem+= i;
        }

        Console.Write(mensagem);
    }

}
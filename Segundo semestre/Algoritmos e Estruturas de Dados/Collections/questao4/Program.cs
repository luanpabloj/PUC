namespace questao4;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine());
        
        fibonacci(n);
    }

    static void fibonacci(int n){

        int soma = 0, cont = 1, cont1 = 0;
        Queue<int> fila = new Queue<int>();

        for(int i = 0; i < n; i++){
            fila.Enqueue(soma);
            soma = cont;
            cont+= cont1;
            cont1 = soma;
        }

        foreach(int i in fila){
            Console.Write(" " + i);
        }
        
    }
}

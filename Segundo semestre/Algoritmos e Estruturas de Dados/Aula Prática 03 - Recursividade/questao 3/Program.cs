namespace questao_3;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(recursao(n));

    }

    static int recursao(int n){
        if(n <= 1){
            return 1;
        }
        else{
            return n * recursao(n - 2);
        }
    }



}

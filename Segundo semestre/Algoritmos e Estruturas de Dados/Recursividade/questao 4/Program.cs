namespace questao_4;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(recursao(n));
    }

    static int recursao(int n){
        if(n == 0){
            return 0;
        }
        else if(n == 1){
            return 1;
        }
        else{
            return 2 * recursao(n - 1) + recursao(n - 2);
        }
    }
}

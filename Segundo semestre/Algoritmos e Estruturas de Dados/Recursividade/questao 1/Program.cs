namespace questao_1;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = somaCubo(n);
        Console.WriteLine(x);
    }

    static int somaCubo(int n){
        if(n == 1){
            return 1;
        }
        else{
            return (int) Math.Pow(n, 3) + somaCubo(n - 1);
        }
    }
}

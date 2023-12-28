namespace questao_6;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(recursaoDois(n));
    }

    static int recursao(int n){
        if(n == 0){
            return 1;
        }
        else{
            return n * recursao(n - 1);
        }

    }

    static int recursaoDois(int n){
        if(n == 0){
            return 1;
        }
        else{
            return recursao(n) * recursaoDois(n - 1);
        }
    }
}

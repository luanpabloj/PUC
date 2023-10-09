namespace questao_5;
class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int r = recursao(x, y);

        Console.WriteLine(r);
    }

    static int recursao(int x, int y){
        if(y == 0){
            return x;
        }
        else{
            return recursao(y, x % y);
        }
    }
}

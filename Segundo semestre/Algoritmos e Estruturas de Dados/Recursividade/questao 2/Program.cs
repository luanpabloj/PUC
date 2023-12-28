namespace questao_2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static int SomaSerie(int i, int j, int k){
        if(i >= j){
            return 1;
        }
        else{
            return i + SomaSerie(i + k, j, k);
        }
    }
}

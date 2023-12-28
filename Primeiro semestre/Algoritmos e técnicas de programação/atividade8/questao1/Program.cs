namespace questao1;
class Program
{
    static void Main(string[] args)
    {
        
        int baseMaior=0, baseMenor=0, altura=0;
        double area=0;

        Console.WriteLine("Digite o valor da base maior");
        baseMaior = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da base menor");
        baseMenor = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da altura");
        altura = int.Parse(Console.ReadLine());

        area = areaT(baseMaior, baseMenor, altura);

        Console.WriteLine("área: " + area);


    }


    public static double areaT(int B, int b, int h){

        double area = (B+b)*h/2;
        return area;
    }
}

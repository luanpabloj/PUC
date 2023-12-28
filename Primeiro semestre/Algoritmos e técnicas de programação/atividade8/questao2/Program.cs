namespace questao2;
class Program
{
    static void Main(string[] args)
    {
        int num=0;
        bool verdadeoufalso=false;

        Console.WriteLine("Digite um número para verificar se ele é divisível por 5");
        num = int.Parse(Console.ReadLine());

        verdadeoufalso = divisao(num);

        Console.WriteLine(verdadeoufalso);


    }

    public static bool divisao(int numero){

    if (numero % 5 == 0){
        return true;
    }
    else{
        return false;
    }

    }
}

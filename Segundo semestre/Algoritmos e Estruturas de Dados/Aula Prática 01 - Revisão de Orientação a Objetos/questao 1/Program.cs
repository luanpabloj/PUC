namespace questao_1;

class Retangulo{
    private double largura;
    private double altura;

    public Retangulo(double largura, double altura){

        this.largura = largura;
        this.altura = altura;

    }

    public double area (){

        return largura * altura;        

    }

    public double perimetro (){
        
        return 2*(largura + altura);
    }

}



class Program
{
    static void Main(string[] args)
    {
        
        double altura = 0;
        double largura = 0;

        altura = double.Parse(Console.ReadLine());
        largura = double.Parse(Console.ReadLine());

        Retangulo retangulo = new Retangulo(altura, largura);


        Console.WriteLine("Área: " + retangulo.area());
        Console.WriteLine("Perímetro: " + retangulo.perimetro());

    }
}

namespace questao_6;

class Triangulo{
    private double lado1;
    private double lado2;
    private double lado3;

    public Triangulo(double lado1, double lado2, double lado3){
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public string tipodetriangulo(){

        if((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 == lado3 && lado2 != lado3)){
            return "isósceles";
        }

        else if(lado1 == lado2 && lado1 == lado3){
            return "equilátero";
        }
        else{
            return "escaleno";
        }

    }



}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a medida dos três lados do triângulo:");
        double lado1 = double.Parse(Console.ReadLine());
        double lado2 = double.Parse(Console.ReadLine());
        double lado3 = double.Parse(Console.ReadLine());

        Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

        Console.WriteLine("Esse triângulo é " + triangulo.tipodetriangulo());
    }
}
namespace questao3;
class Program
{
    static void Main(string[] args)
    {
        double litros=0, tipo=0, preco=0, valor=0; 

        Console.WriteLine("Digite o tipo de combustível (0 para álcool e 1 para gasolina)");
        tipo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de combustível");
        litros = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor por litro do combustível");
        preco = double.Parse(Console.ReadLine());

        preco = calculo(tipo, preco, litros);

        Console.WriteLine("valor a ser pago: R$" + preco);

    }

    public static double calculo(double combustivel, double valor, double litros){

        if(combustivel == 0){
            if(litros <= 20){
                valor = valor * 0.97*10;

            }
            else if(litros > 20){
                valor = valor * 0.95*10;

            }
        }

        else if(combustivel == 1){
            if(litros <= 20){
                valor = valor * 0.96*10;

           }
           else if(litros > 20){
            valor = valor * 0.94*10;
           }
        }

       return valor;


    }
}

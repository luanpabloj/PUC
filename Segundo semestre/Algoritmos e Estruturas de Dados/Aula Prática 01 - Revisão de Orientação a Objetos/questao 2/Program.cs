namespace questao_2;

class ContaBancaria{

    private double saldo;
    private String titular;

    public ContaBancaria(double saldo, String titular){
        this.saldo = saldo;
        this.titular = titular;
    }

    public void deposito(double depositar){

        saldo = saldo + depositar;

    }


    public void saque(double sacar){

        saldo = saldo - sacar;

    }

    public double mostrarSaldo(){

        return saldo;

    }

}


class Program
{
    static void Main(string[] args)
    {
        double saldo = 0, depositar = 0, sacar = 0;
        String titular = "";

        Console.Write("Digite o nome do titular: ");
        titular = Console.ReadLine();
        Console.Write("Digite o saldo inicial: ");
        saldo = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor a ser depositado: ");
        depositar = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor a ser sacado: ");
        sacar = double.Parse(Console.ReadLine());

        ContaBancaria contaBancaria = new ContaBancaria(saldo, titular);

        contaBancaria.deposito(depositar);
        contaBancaria.saque(sacar);


        Console.WriteLine("");
        Console.WriteLine("Saldo atual: " + contaBancaria.mostrarSaldo());

    }
}

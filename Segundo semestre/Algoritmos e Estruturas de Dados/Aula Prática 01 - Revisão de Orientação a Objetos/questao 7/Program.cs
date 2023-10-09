namespace questao_7;

class Funcionario{
    private string nome;
    private string cargo;
    private double salario;

    public Funcionario(string nome, string cargo, double salario){
        this.nome = nome;
        this.cargo = cargo;
        this.salario = salario;
    }

    public string dados(){
        return "Nome: " + nome + " \ncargo: " + cargo + "\nsalario: " + salario;
    }



}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os dados do usuário a ser cadastrado no sistema");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Cargo: ");
        string cargo = Console.ReadLine();
        Console.Write("Salário: ");
        double salario = double.Parse(Console.ReadLine());

        Funcionario funcionario = new Funcionario(nome, cargo, salario);

        Console.WriteLine("");
        Console.WriteLine("Usuário cadastrado: \n" + funcionario.dados());
    }
}

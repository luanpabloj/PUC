using questao_4;

namespace questao_4;

class Aluno{

    private String nome;
    private int matricula;
    private double[] notas;

    public Aluno (String nome, int matricula, double[] notas){
        this.nome = nome;
        this.matricula = matricula;
        this.notas = notas;
    }

    public double media(){

        double soma = 0;

        foreach(double nota in notas){
            soma+= nota;
        }


    return soma / notas.Length;

    }

    public void imprimir(){
        Console.WriteLine("Aluno: " + nome + "\nMatrícula: " + matricula + "\nMédia: " + media());
    }
    


}


class Program
{
    static void Main(string[] args)
    {
        double soma = 0;

        Console.Write("Digite o nome do aluno: ");
        String nome = Console.ReadLine();
        Console.Write("Digite a matrícula do aluno: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de notas a ser adicionadas: ");
        int cont = int.Parse(Console.ReadLine());

        double[] notas = new double[cont];

        for(int i = 0; i < cont; i++){
            Console.Write("Digite a nota " + (i + 1) + ": ");
            notas[i] = double.Parse(Console.ReadLine());
            soma += notas[i];
        }

        Aluno aluno = new Aluno(nome, matricula, notas);
        
        aluno.imprimir();

    }
}

namespace questao4;
class Program
{
    static void Main(string[] args)
    {
        
        int nota=0, frequencia=0;
        string result="", aluno="";

        Console.WriteLine("Digite o nome do aluno");
        aluno = Console.ReadLine();

        Console.WriteLine("Digite a nota do " + aluno);
        nota = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a frequência do aluno (sem usar o sinal de porcentagem)");
        frequencia = int.Parse(Console.ReadLine());

        result = metodo(nota, frequencia);

        Console.WriteLine("A nota do aluno: " + aluno + " é: " + nota + " e a frequência: " + frequencia + "%");
        Console.WriteLine("Resultado: " + result);

    }

    public static string metodo(int nota, int frequencia){

        string resultado="";
        
        if(nota >= 60){
            if(frequencia >= 75){
                resultado = "aprovado";
            }
            else if(frequencia < 75){
                resultado = "reprovado";
            }
        }

        else if(nota < 60){
            resultado = "reprovado";
        }

        return resultado;
    }
}

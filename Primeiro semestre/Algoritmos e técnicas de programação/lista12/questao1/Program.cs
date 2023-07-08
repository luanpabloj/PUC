using System.IO;

string[] nome = new string[10];
double[] nota = new double[10];
string[] disciplina = new string[10];
int[] matricula = new int[10];


StreamWriter arquivo = new StreamWriter("bancodedados.txt");

for(int i = 0; i < 1; i++)
{
    Console.WriteLine("Digite o nome do aluno: " + (i+1));
    nome[i] = Console.ReadLine();

    Console.WriteLine("Digite a matrícula do aluno");
    matricula[i] = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o nome da disciplina");
    disciplina[i] = Console.ReadLine();

    Console.WriteLine("Digite a nota final do aluno");
    nota[i] = int.Parse(Console.ReadLine());

    arquivo.WriteLine($"Nome do aluno: {nome[i]}, matrícula: {matricula[i]}, disciplina: {disciplina[i]}, nota final: {nota[i]}");
}



arquivo.Close();
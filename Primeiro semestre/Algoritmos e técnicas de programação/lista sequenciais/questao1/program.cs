Console.WriteLine("Digite três notas do aluno");
int nota1 = int.Parse(Console.ReadLine());
int nota2 = int.Parse(Console.ReadLine());
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso das notas do aluno");
int peso1 = int.Parse(Console.ReadLine());
int peso2 = int.Parse(Console.ReadLine());
int peso3 = int.Parse(Console.ReadLine());

float mediap=0;

mediap = ((nota1*peso1)+(nota2*peso2)+(nota3*peso3))/(peso1+peso2+peso3);

Console.WriteLine("média ponderada da nota do aluno: {0}", mediap);

Console.WriteLine("Luan Pablo Mendes Amaral");
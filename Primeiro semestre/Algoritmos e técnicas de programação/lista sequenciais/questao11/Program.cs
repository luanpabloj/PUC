
Console.WriteLine("Digite o número de horas trabalhadas");
double horasTrab = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do salário mínimo");
double salarioMinimo = double.Parse(Console.ReadLine());


double valorHoraTrab = salarioMinimo/2;

double salarioBruto = valorHoraTrab * horasTrab;

double imposto = salarioBruto*0.03;

double salarioLiquido = salarioBruto - imposto;

Console.WriteLine("Valor da hora trabalhada: {0}", valorHoraTrab);
Console.WriteLine("Valor do salário bruto: {0}", salarioBruto);
Console.WriteLine("Valor do imposto: {0}", imposto);
Console.WriteLine("Valor do salário líquido: {0}", salarioLiquido);
Console.WriteLine("Luan Pablo Mendes Amaral");


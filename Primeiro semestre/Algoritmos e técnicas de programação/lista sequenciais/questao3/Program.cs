
Console.WriteLine("Digite o salário do funcionário");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o aumento percentual salarial do funcionário");
double percentual = double.Parse(Console.ReadLine());

double aumento=0;

aumento = salario * ((percentual/100)+1.00);

Console.WriteLine("o salário do funcionário com aumento é de: {0}", aumento);
Console.WriteLine("Luan Pablo Mendes Amaral");


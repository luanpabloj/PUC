

int numF=0, horasT=0, valorH=0, salario=0;

Console.WriteLine("Digite o número do funcionário");
numF = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas");
horasT = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor por hora trabalhada");
valorH = int.Parse(Console.ReadLine());

salario = horasT * valorH;

Console.WriteLine("O funcionário com a matrícula " + numF + " trabalhou " + horasT + " horas, e o seu salário mensal é " + salario);

Console.WriteLine("Luan Pablo Mendes Amaral");
Console.WriteLine("Digite o valor do salário mínimo");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de quilowatts consumida");
double qntQw = double.Parse(Console.ReadLine());

double valorQw = salario/5;
double valorapagar = valorQw * qntQw;
double desconto = valorapagar-(valorapagar*0.15);

Console.WriteLine("Valor de cada Quilowatt: {0}", valorQw);
Console.WriteLine("Valor a pagar pela quantidade consumida: {0}", valorapagar);
Console.WriteLine("Valor a pagar com desconto de 15%: {0}", desconto);

Console.WriteLine("Luan Pablo Mendes Amaral");





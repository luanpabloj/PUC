
Console.WriteLine("Digite o valor do depósito");
double deposito = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da taxa de juros mensal");
double taxa = double.Parse(Console.ReadLine());


double jurosMensal=0; 
jurosMensal = deposito*((taxa/100)*1.00)+deposito;

double jurosAnual=0;
jurosAnual = jurosMensal * 12;

Console.WriteLine("O valor a receber com juros mensal é de: {0}", jurosMensal);
Console.WriteLine("Juros anual: {0}", jurosAnual);

Console.WriteLine("Luan Pablo Mendes Amaral");



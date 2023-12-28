Console.WriteLine("Digite o peso do saco de ração em quilos");
double saco = double.Parse(Console.ReadLine())*1000;

Console.WriteLine("Digite a quantidade de ração para o gato 1 em gramas");
double gato1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de ração para o gato 2 em gramas");
double gato2 = double.Parse(Console.ReadLine());


double qnt = saco-(((gato1 + gato2)*5)/1000);


Console.WriteLine("Restará " + qnt + " Kg de ração após 5 dias");
Console.WriteLine("Luan Pablo Mendes Amaral");
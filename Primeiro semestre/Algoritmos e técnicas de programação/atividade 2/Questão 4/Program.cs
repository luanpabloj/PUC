int brancos=0, nulos=0, validos=0;
double percentualB=0, percentualN=0, percentualV=0, eleitores=0;

Console.WriteLine("Digite o número de eleitores da cidade");
eleitores = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os votos em brancos");
brancos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os votos nulos");
nulos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os votos válidos");
validos = int.Parse(Console.ReadLine());

percentualB = (brancos/eleitores)*100;
percentualN = (nulos/eleitores)*100;
percentualV = (validos/eleitores)*100;

Console.WriteLine("Percentual dos votos brancos: " + percentualB + "%");
Console.WriteLine("Percentual dos votos nulos: " + percentualN + "%");
Console.WriteLine("Percentual dos votos válidos: " + percentualV + "%");

Console.WriteLine("Luan Pablo Mendes Amaral");

Console.WriteLine("Digite o preço de fábrica do veículo");
double precoVeiculo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o percentual de lucro do distribuidor");
double lucroDist = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o percentual de impostos");
double impostos = double.Parse(Console.ReadLine());

double custoVeiculo=0, lucroDist2=0, valorImpostos=0;

custoVeiculo = precoVeiculo + (precoVeiculo * (lucroDist/100)) + (precoVeiculo*(impostos/100));
lucroDist2 = precoVeiculo * (lucroDist/100);
valorImpostos = precoVeiculo * (impostos/100);


Console.WriteLine("Lucro do distribuidor: {0}", lucroDist2);
Console.WriteLine("Impostos: {0}", valorImpostos);
Console.WriteLine("Preço final do veículo: {0}", custoVeiculo);
Console.WriteLine("Luan Pablo Mendes Amaral");


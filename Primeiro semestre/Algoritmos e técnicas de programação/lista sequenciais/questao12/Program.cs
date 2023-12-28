
Console.WriteLine("Digite o valor a ser depositado na conta bancária");
double valor = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do cheque a ser emitido");
double cheque1 = double.Parse(Console.ReadLine());
double movimentacaoBancaria1 = valor - cheque1;

Console.WriteLine("Digite o valor do cheque a ser emitido");
double cheque2 = double.Parse(Console.ReadLine());
double movimentacaoBancaria2 = movimentacaoBancaria1 - cheque2;

Console.WriteLine("Você deseja consultar o seu saldo?");
String consultar = Console.ReadLine();


string casosim="sim";

if(consultar == casosim ){
    double valorconsulta = (movimentacaoBancaria1 + movimentacaoBancaria2)*0.38;
    Console.WriteLine("Saldo atual com CPMF cobrado: {0}", valorconsulta);
}
else{
    Console.WriteLine("fim");
}

Console.WriteLine("Luan Pablo Mendes Amaral");



Console.WriteLine("digite o ano de nascimento e o ano atual");
int nascimento = int.Parse(Console.ReadLine());
int atual = int.Parse(Console.ReadLine());

int idade=0, ifuturo=0;

idade = atual - nascimento;
ifuturo = 2050 - nascimento;

Console.WriteLine("Idade: {0}", idade);
Console.WriteLine("Idade em 2050: {0}", ifuturo);
Console.WriteLine("Luan Pablo Mendes Amaral");


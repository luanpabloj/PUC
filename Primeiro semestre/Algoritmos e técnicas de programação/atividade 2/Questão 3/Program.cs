int numT=0, totalP=0, valorP=0, saldo=0;

Console.WriteLine("Digite o número total de prestações");
numT = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o total de prestações pagas");
totalP = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor atual da prestação");
valorP = int.Parse(Console.ReadLine());

saldo = (numT - totalP) * valorP;

Console.WriteLine("O usuário pagou " + totalP + " de " + numT + " parcelas. O valor total a pagar as parcelas restantes é de: " + saldo);

Console.WriteLine("Luan Pablo Mendes Amaral");

Console.WriteLine("digite um número");
int numero = int.Parse(Console.ReadLine());

double quadrado=0, cubo=0, raizQuadrada=0, raizCubica=0;

quadrado = numero*numero;
cubo = numero*numero*numero;
raizQuadrada = Math.Pow(numero, 0.5);
raizCubica = Math.Pow(numero, 1/3);

Console.WriteLine("Número ao quadrado: {0}", quadrado);
Console.WriteLine("Número ao cubo: {0}", cubo);
Console.WriteLine("Raiz quadrada do número: {0}", raizQuadrada);
Console.WriteLine("Raiz cúbica do número: {0}", raizCubica);

Console.WriteLine("Luan Pablo Mendes Amaral");





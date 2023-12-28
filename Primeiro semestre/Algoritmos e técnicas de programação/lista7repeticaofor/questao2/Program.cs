double s=0, elevado=3, numerador=0, denominador=0, x=1;

Console.WriteLine("Digite o valor de X");
x = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++){

numerador = x*i;
denominador = Math.Pow(i, 3);
s+= numerador/denominador;

}

Console.WriteLine("S: " + s);
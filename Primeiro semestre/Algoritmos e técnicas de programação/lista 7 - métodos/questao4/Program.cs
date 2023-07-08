
Console.WriteLine("Digite um número");
int n = int.Parse(Console.ReadLine());

calculo(n);

void calculo(int n)
{
    int fatorial = n;
    int cont = n;
    int  s = 0;

    for (int i = n - 1; i >= 1; i--)
    {
        for( int j = 0; j <= n; j++){
        s+= 1 + (1/(fatorial*i));
        }
    }

    Console.WriteLine("Valor de S: " + s);


}
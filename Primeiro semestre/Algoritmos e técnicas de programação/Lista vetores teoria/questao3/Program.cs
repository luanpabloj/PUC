int n = 10, menor = 0;

int[] vet = new int[n];

Console.WriteLine("Digite 10 valores");

for (int i = 0; i < n; i++)
{

    vet[i] = int.Parse(Console.ReadLine());

}

for (int i = 0; i < n; i++)
{

    for (int j = 0; j < n; j++)
    {

        if (vet[i] > vet[j])
        {

            menor = vet[i];
            vet[i] = vet[j];
            vet[j] = menor;

        }

    }

}
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Resultado: " + vet[i]);
}

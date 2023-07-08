string[] nomeLojas = new string[8];
string[] nomeProdutos = new string[4];
double[,] precoProdutos = new double[8, 4];


cadastrarLojas(nomeLojas);
cadastrarNomeProdutos(nomeProdutos);
cadastrarProdutosNasLojas(precoProdutos, nomeProdutos, nomeLojas);
imprimir(precoProdutos, nomeProdutos, nomeLojas);

void cadastrarLojas(string[] nomeLojas)
{
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Digite o nome da loja " + (i + 1));
        nomeLojas[i] = Console.ReadLine();
    }
}

void cadastrarNomeProdutos(string[] nomeProdutos)
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Digite o nome do produto " + (i + 1));
        nomeProdutos[i] = Console.ReadLine();
    }
}


void cadastrarProdutosNasLojas(double[,] precoProdutos, string[] nomeProdutos, string[] nomeLojas)
{
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Digite os valores dos produtos para a loja " + nomeLojas[i]);

        for (int j = 0; j < 4; j++)
        {
            Console.WriteLine("Produto: " + nomeProdutos[j]);
            precoProdutos[i, j] = double.Parse(Console.ReadLine());
        }
    }

}


void imprimir(double[,] precoProdutos, string[] nomeProdutos, string[] nomeLojas)
{
    Console.WriteLine("Nome das lojas e produtos em que o preço não é maior que R$120,00");

    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Loja: " + nomeLojas[i]);

        for(int j = 0; j < 4; j++)
        {
            if(precoProdutos[i, j] < 120.00)
            {
                Console.WriteLine("produto: " + nomeProdutos[j]);
            }

        }
    }

}
string linha;

StreamReader arquivo = new StreamReader(@"C:\Users\luant\OneDrive\Área de Trabalho\puc\ATP\lista12\questao1\bancodedados.txt");

linha = arquivo.ReadLine();
while (linha != null)
{
    Console.WriteLine(linha);
    linha = arquivo.ReadLine();
}

arquivo.Close();

namespace questao_2;
class Program
{
    static void Main(string[] args)
    {
        List<int> lista = new List<int>();

        Dictionary<int, int> dicionario = new Dictionary<int, int>();

        addNumero(lista);
        repetidos(dicionario, lista);


        int opcao = 0;

        do{
            Console.WriteLine("1 - Verificar se um determinado número consta no dicionário\n2 - Dar a opção de se consultar quantos números distintos, constam no dicionário\n3 - Imprimir todos os números e suas frequências de ocorrências\n4 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    Console.Write("Digite o número a ser pesquisado: ");
                    int number = int.Parse(Console.ReadLine());
                    verificar(dicionario, number);
                    break;

                case 2:
                    Console.WriteLine($"Tem {dicionario.Count} números distintos no dicionário");
                    break;
                
                case 3:
                    numerosFrequencia(dicionario);
                    break;

            }


        }while(opcao != 4);
    }

    static void addNumero(List<int> lista){
        Console.WriteLine("Digite 10 números");
        for(int i = 0; i < 10; i++){
        int num = int.Parse(Console.ReadLine());
        lista.Add(num);
        }
    }

    static void repetidos(Dictionary<int, int> dicionario, List<int> lista){
                foreach(int i in lista){
            if(dicionario.ContainsKey(i)){
                dicionario[i]++;
            }
            else{
                dicionario[i] = 1;
            }
        }
    }

    static void verificar(Dictionary<int, int> dicionario, int number){
        if(dicionario.ContainsKey(number)){
            Console.WriteLine("Número encontrado");
        }
        else{
            Console.WriteLine("Número não encontrado");
        }
    }

    static void numerosFrequencia(Dictionary<int, int> dicionario){
        foreach(var i in dicionario){
            Console.WriteLine($"Número: {i.Key} frequência: {i.Value}");
        }
    }
}

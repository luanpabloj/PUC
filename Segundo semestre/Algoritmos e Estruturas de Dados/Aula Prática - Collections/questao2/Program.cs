namespace questao2;

class Numeros{

    private List<int> list = new List<int>();

    public void adicionarNum(int num){
        list.Add(num);
        Console.WriteLine($"Número {num} adicionado na lista");
    }

    public void verificacao(int num){
        if(list.Contains(num) == true){
            Console.WriteLine($"O número {num} já se encontra cadastrado na lista");
        }
        else{
            Console.WriteLine($"O número {num} não está cadastrado na lista");
        }
    }

    public void soma(){
        int som = 0;
        foreach(int i in list){
            som = som + i;
        }

        Console.WriteLine("Soma de todos os números da lista: " + som);
    }

    public void maiorNum(){

        int n = list.Count, auxiliar = 0;

        int[] maiorN = new int[n];

        maiorN = list.ToArray();

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(maiorN[i] < maiorN[j]){
                    auxiliar = maiorN[i];
                    maiorN[i] = maiorN[j];
                    maiorN[j] = maiorN[i];
                }
            }
        }

        Console.WriteLine("Maior número da lista: " + maiorN[0]);
    }

        public void menorNum(){

        int n = list.Count, auxiliar = 0;

        int[] menorN = new int[n];

        menorN = list.ToArray();

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(menorN[i] > menorN[j]){
                    auxiliar = menorN[i];
                    menorN[i] = menorN[j];
                    menorN[j] = menorN[i];
                }
            }
        }

        Console.WriteLine("Menor número da lista: " + menorN[0]);
    }

    public void removerPares(){
        
        int n = list.Count;

        int[] pares = new int[n];

        pares = list.ToArray();

        for(int i = 0; i < n; i++){
            if(pares[i] % 2 == 0){
                list.RemoveAt(i);
            }
        }

        Console.WriteLine("Números pares removidos da lista");
    }

    public void exibir(){
        foreach(int i in list){
            Console.WriteLine(i);
        }
    }

    public void inverter(){
        list.Reverse();
    }
}


class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        Numeros list = new Numeros();
        int opcao = 0;

        do{

            Console.WriteLine("Escolha uma opção:\n1 - Insira um número na lista\n2 - Verifique se um número está na lista\n3 - Exiba a soma de todos os números na lista\n4 - Exiba o maior número na lista\n5 - Exiba o menor número na lista\n6 - Remova todos os números pares da lista\n7 - Exiba os números na lista após a remoção dos números pares\n8 - Inverta os elementos da lista\n9 - Encerre o programa");

            opcao = int.Parse(Console.ReadLine());
            
            switch(opcao){
                case 1:
                    Console.Write("Digite um número inteiro para ser incluido na lista: ");
                    num = int.Parse(Console.ReadLine());
                    list.adicionarNum(num);
                    Console.WriteLine("Número incluido na lista");
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                break;
                case 2:
                    Console.Write("Digite o número a ser verificado na lista: ");
                    num = int.Parse(Console.ReadLine());
                    list.verificacao(num);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                break;
                case 3: 
                    list.soma();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 4:
                    list.maiorNum();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 5:
                    list.menorNum();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                   
                break;
                case 6:
                    list.removerPares();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 7:
                    list.exibir();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 8:
                    list.inverter();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                
            }
            
        }while(opcao != 9);
        Console.WriteLine("Fim do programa");
    }
}

namespace questao2;

class Lista {

    private int[] array;
    private int n;
    
    public Lista (){
    
        Inicializar(0);
    }
    public Lista (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new int[tamanho];
        this.n = 0;
    }
    
    public void inserirInicio(int x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > 0; i--){
            array[i] = array[i-1];
        }
        array[0] = x;
        n++;
    }
    
    public void inserirFim(int x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        array[n] = x;
        n++;
    }
    
    public void inserir(int x, int pos) {
        if (n >= array.Length || pos < 0 || pos > n)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > pos; i--){
            array[i] = array[i-1];
        }
        array[pos] = x;
        n++;
    }
    
    public int removerInicio() {
        if (n == 0)
            throw new Exception("Erro!");
        int resp = array[0];
        n--;
        for (int i = 0; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public int removerFim() {
        if (n == 0)
            throw new Exception("Erro!");
        n = n-1;
        return array[n];
    }
    
    public int remover(int pos) {
        if (n == 0 || pos < 0 || pos >= n)
            throw new Exception("Erro!");
        int resp = array[pos];
        n--;
        for (int i = pos; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public void mostrar (){
        Console.Write("[ ");
        for (int i = 0; i < n; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }

    public void verificar(int x){
        for(int i = 0; i < n; i++){
            if(array[i] == x){
                Console.WriteLine("Número encontrado na lista");
            }
            else{
                Console.WriteLine("Número não encontrado na lista");
            }
        }
    }

    public void soma(){
        int resultado = 0;
        for(int i = 0; i < n; i++){
            resultado+= array[i];
        }

        Console.WriteLine("Resultado: " + resultado);
    }

    public void maiorNum(){
        int auxiliar = 0;
        for(int i = 0; i < n; i++){
            if(auxiliar < array[i]){
                auxiliar = array[i];
            }
        }

        Console.WriteLine("Maior número: " + auxiliar);
    }

    public void menorNum(){
        int auxiliar = array[0];
        for(int i = 0; i < n; i++){
            if(auxiliar > array[i]){
                auxiliar = array[i];
            }
        }

        Console.WriteLine("Menor número: " + auxiliar);
    }

    public void removerPares(){
        for(int i = 0; i < n; i++){
            if(array[i] % 2 == 0){
                array[i] = 0;
            }
        }
    }

    public void inverter(){
         for (int i = 0; i < n / 2; i++){
                int temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }
    }
}


class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        Lista lista = new Lista(6);
        int opcao = 0;

        do{

            Console.WriteLine("Escolha uma opção:\n1 - Insira um número na lista\n2 - Verifique se um número está na lista\n3 - Exiba a soma de todos os números na lista\n4 - Exiba o maior número na lista\n5 - Exiba o menor número na lista\n6 - Remova todos os números pares da lista\n7 - Exiba os números na lista após a remoção dos números pares\n8 - Inverta os elementos da lista\n9 - Encerre o programa");

            opcao = int.Parse(Console.ReadLine());
            
            switch(opcao){
                case 1:
                    Console.Write("Digite um número inteiro para ser incluido na lista: ");
                    x = int.Parse(Console.ReadLine());
                    lista.inserirFim(x);
                    Console.WriteLine("Número incluido na lista");
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                break;
                case 2:
                    Console.Write("Digite o número a ser verificado na lista: ");
                    x = int.Parse(Console.ReadLine());
                    lista.verificar(x);
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");
                break;
                case 3: 
                    lista.soma();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 4:
                    lista.maiorNum();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 5:
                    lista.menorNum();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                   
                break;
                case 6:
                    lista.removerPares();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 7:
                    lista.mostrar();
                    Console.WriteLine(" ");
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine(" ");                    
                break;
                case 8:
                    lista.inverter();
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

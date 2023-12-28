using System.Diagnostics;
using System.IO;
using System.Text;


namespace bolha;
class Program
{

        static int mediaComparacoesBolha = 0, mediaMovimentacoesBolha = 0;
       static  long mediaTempoBolha = 0;
        static int mediaComparacoesSelecao = 0, mediaMovimentacoesSelecao = 0;
       static long mediaTempoSelecao = 0;
        static int mediaComparacoesInsercao = 0, mediaMovimentacoesInsercao = 0;
        static long mediaTempoInsercao = 0;
    static void Main(string[] args)
    {

        StreamWriter arquivo = new StreamWriter("relatório.txt", true, Encoding.UTF8);


        int[] array = new int[10000];

        Random aleatorios = new Random();

        for(int i = 0;  i < array.Length; i++){
            array[i] = aleatorios.Next(1, array.Length);
        }

        bolha(array, arquivo);
        selecao(array, arquivo);
        insercao(array, arquivo);

        arquivo.WriteLine("=================================================");
        arquivo.WriteLine("Vetor de tamanho: " + array.Length);
        arquivo.WriteLine("Média do tempo de execução da bolha: " + (mediaTempoBolha/30));
        arquivo.WriteLine("Média das comparações da bolha: " + (mediaComparacoesBolha/30));
        arquivo.WriteLine("Média das movimentações da bolha: " + (mediaMovimentacoesBolha/30));
        arquivo.WriteLine("=================================================");

        arquivo.WriteLine("=================================================");
        arquivo.WriteLine("Vetor de tamanho: " + array.Length);
        arquivo.WriteLine("Média do tempo de execução da seleção: " + (mediaTempoSelecao/30));
        arquivo.WriteLine("Média das comparações da seleção: " + (mediaComparacoesSelecao/30));
        arquivo.WriteLine("Média das movimentações da seleção: " + (mediaMovimentacoesSelecao/30));
        arquivo.WriteLine("=================================================");

        arquivo.WriteLine("=================================================");
        arquivo.WriteLine("Vetor de tamanho: " + array.Length);
        arquivo.WriteLine("Média do tempo de execução da inserção: " + (mediaTempoInsercao/30));
        arquivo.WriteLine("Média das comparações da inserção: " + (mediaComparacoesInsercao/30));
        arquivo.WriteLine("Média das movimentações da inserção: " + (mediaMovimentacoesInsercao/30));
        arquivo.WriteLine("=================================================");

        arquivo.Close();
    }

    static void bolha(int[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
        int[] arrayCopia = (int[]) array.Clone();


        int comparacoesBolha = 0, movimentacoesBolha = 0;


        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length - 1; j > i; j--){
                comparacoesBolha++;
                if (arrayCopia[j] < arrayCopia[j-1]){
                    int temp = arrayCopia[j];
                    arrayCopia[j] = arrayCopia[j-1];
                    arrayCopia[j-1] = temp;
                    movimentacoesBolha++;
                    }
                }
            }

        tempo.Stop();

        arquivo.WriteLine("Método bolha ordenar: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesBolha);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesBolha);
        arquivo.WriteLine(" ");
        mediaTempoBolha+= tempo.ElapsedMilliseconds;
        mediaComparacoesBolha+= comparacoesBolha;
        mediaMovimentacoesBolha+= movimentacoesBolha;
        cont+= 1;

        }while(cont < 10);

        cont = 0;

        do{
        teste += 1;



        int[] arrayCopia = (int[]) array.Clone();

        int comparacoesBolha = 0, movimentacoesBolha = 0;

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length-1; j > i; j--){
                if (arrayCopia[j] < arrayCopia[j-1]){
                    int temp = arrayCopia[j];
                    arrayCopia[j] = arrayCopia[j-1];
                    arrayCopia[j-1] = temp;
                    }
                }
            }

        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length-1; j > i; j--){
                comparacoesBolha++;
                if (arrayCopia[j] < arrayCopia[j-1]){
                    int temp = arrayCopia[j];
                    arrayCopia[j] = arrayCopia[j-1];
                    arrayCopia[j-1] = temp;
                    movimentacoesBolha++;
                    }
                }
            }

        tempo.Stop();

        arquivo.WriteLine("Método bolha ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesBolha);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesBolha);
        arquivo.WriteLine("");
        mediaTempoBolha+= tempo.ElapsedMilliseconds;
        mediaComparacoesBolha+= comparacoesBolha;
        mediaMovimentacoesBolha+= movimentacoesBolha;

        cont+= 1;

        }while(cont < 10);

        cont = 0;

        do{
        teste += 1;
        int[] arrayCopia = (int[]) array.Clone();

        

        int comparacoesBolha = 0, movimentacoesBolha = 0;

        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length-1; j > i; j--){
                comparacoesBolha++;
                if (arrayCopia[j] > arrayCopia[j-1]){
                    int temp = arrayCopia[j];
                    arrayCopia[j] = arrayCopia[j-1];
                    arrayCopia[j-1] = temp;
                    movimentacoesBolha++;
                    }
                }
            }
        
        tempo.Stop();


        arquivo.WriteLine("Método bolha inversamente ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesBolha);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesBolha);
        arquivo.WriteLine("");
        cont+= 1;
        mediaTempoBolha+= tempo.ElapsedMilliseconds;
        mediaComparacoesBolha+= comparacoesBolha;
        mediaMovimentacoesBolha+= movimentacoesBolha;

        }while(cont < 10);
    }

    static void selecao(int[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
        teste+= 1;

        

        int[] arrayCopia = (int[]) array.Clone();

        int comparacoesSelecao = 0, movimentacoesSelecao = 0;

        tempo.Start();
        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                comparacoesSelecao++;
                if (arrayCopia[menor] > arrayCopia[j]){
                movimentacoesSelecao++;
                menor = j;
                }
            }
        int temp = arrayCopia[menor];
        arrayCopia[menor] = arrayCopia[i];
        arrayCopia[i] = temp;
        }

        tempo.Stop();

        arquivo.WriteLine("Método seleção ordenar: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesSelecao);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesSelecao);
        arquivo.WriteLine("");
        mediaTempoSelecao+= tempo.ElapsedMilliseconds;
        mediaComparacoesSelecao+= comparacoesSelecao;
        mediaMovimentacoesSelecao+= movimentacoesSelecao;

        cont+= 1;

        }while(cont < 10);

        

        cont = 0;

        do{
        teste+= 1;
        int[] arrayCopia = (int[]) array.Clone();
        

        int comparacoesSelecao = 0, movimentacoesSelecao = 0;

        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                if (arrayCopia[menor] > arrayCopia[j]){
                menor = j;
                }
            }
        int temp = arrayCopia[menor];
        arrayCopia[menor] = arrayCopia[i];
        arrayCopia[i] = temp;
        }

        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                comparacoesSelecao++;
                if (arrayCopia[menor] > arrayCopia[j]){
                movimentacoesSelecao++;
                menor = j;
                }
            }
        int temp = arrayCopia[menor];
        arrayCopia[menor] = arrayCopia[i];
        arrayCopia[i] = temp;
        }

        tempo.Stop();
        arquivo.WriteLine("Método seleção ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesSelecao);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesSelecao);
        arquivo.WriteLine("");
        mediaTempoSelecao+= tempo.ElapsedMilliseconds;
        mediaComparacoesSelecao+= comparacoesSelecao;
        mediaMovimentacoesSelecao+= movimentacoesSelecao;
            
            cont+= 1;
        }while(cont < 10);

        cont = 0;

        do{
        teste+= 1;
        int[] arrayCopia = (int[]) array.Clone();

        int comparacoesSelecao = 0, movimentacoesSelecao = 0;

        

        tempo.Start();
        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                comparacoesSelecao++;
                if (arrayCopia[menor] < arrayCopia[j]){
                movimentacoesSelecao++;
                menor = j;
                }
            }
        int temp = arrayCopia[menor];
        arrayCopia[menor] = arrayCopia[i];
        arrayCopia[i] = temp;
        }

        tempo.Stop();

        arquivo.WriteLine("Método seleção inversamente ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesSelecao);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesSelecao);
        arquivo.WriteLine("");
        mediaTempoSelecao+= tempo.ElapsedMilliseconds;
        mediaComparacoesSelecao+= comparacoesSelecao;
        mediaMovimentacoesSelecao+= movimentacoesSelecao;

        cont+= 1;

        }while(cont < 10);
    }


    static void insercao(int[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
            teste+= 1;
            int[] arrayCopia = (int[]) array.Clone();

            

            int movimentacoesInsercao = 0, comparacoesInsercao = 0;

            tempo.Start();

            for (int i = 1; i < arrayCopia.Length; i++) {
                int tmp = arrayCopia[i];
                int j = i - 1;
                comparacoesInsercao += 1;
                while ( (j >= 0) && (arrayCopia[j] > tmp) ){
                movimentacoesInsercao += 1;
                arrayCopia[j + 1] = arrayCopia[j];
                j--;
                }
                arrayCopia[j + 1] = tmp;
                }

            tempo.Stop();

        arquivo.WriteLine("Método inserção ordenar: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesInsercao);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesInsercao);
        arquivo.WriteLine("");
        mediaTempoInsercao+= tempo.ElapsedMilliseconds;
        mediaComparacoesInsercao+= comparacoesInsercao;
        mediaMovimentacoesInsercao+= movimentacoesInsercao;

        cont+= 1;
        }while(cont < 10);

        cont = 0;

        do{
        teste+= 1;
                    int[] arrayCopia = (int[]) array.Clone();

            

            int movimentacoesInsercao = 0, comparacoesInsercao = 0;

            for (int i = 1; i < arrayCopia.Length; i++) {
                int tmp = arrayCopia[i];
                int j = i - 1;
                while ( (j >= 0) && (arrayCopia[j] > tmp) ){
                arrayCopia[j + 1] = arrayCopia[j];
                j--;
                }
                arrayCopia[j + 1] = tmp;
                }

            tempo.Start();

            for (int i = 1; i < arrayCopia.Length; i++) {
                int tmp = arrayCopia[i];
                int j = i - 1;
                comparacoesInsercao += 1;
                while ( (j >= 0) && (arrayCopia[j] > tmp) ){
                movimentacoesInsercao += 1;
                arrayCopia[j + 1] = arrayCopia[j];
                j--;
                }
                arrayCopia[j + 1] = tmp;
                }

            tempo.Stop();

        arquivo.WriteLine("Método inserção ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesInsercao);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesInsercao);
        arquivo.WriteLine("");
        mediaTempoInsercao+= tempo.ElapsedMilliseconds;
        mediaComparacoesInsercao+= comparacoesInsercao;
        mediaMovimentacoesInsercao+= movimentacoesInsercao;

        cont+= 1;
        }while(cont < 10);

        cont = 0;

        do{
        teste+= 1;
            int[] arrayCopia = (int[]) array.Clone();

            

            int movimentacoesInsercao = 0, comparacoesInsercao = 0;

            tempo.Start();

            for (int i = 1; i < arrayCopia.Length; i++) {
                int tmp = arrayCopia[i];
                int j = i - 1;
                comparacoesInsercao += 1;
                while ( (j >= 0) && (arrayCopia[j] < tmp) ){
                movimentacoesInsercao += 1;
                arrayCopia[j + 1] = arrayCopia[j];
                j--;
                }
                arrayCopia[j + 1] = tmp;
                }

            tempo.Stop();

        arquivo.WriteLine("Método inserção inversamente ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesInsercao);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesInsercao);
        arquivo.WriteLine("");
        mediaTempoInsercao+= tempo.ElapsedMilliseconds;
        mediaComparacoesInsercao+= comparacoesInsercao;
        mediaMovimentacoesInsercao+= movimentacoesInsercao;

        cont+= 1;
        }while(cont < 10);
    }
}

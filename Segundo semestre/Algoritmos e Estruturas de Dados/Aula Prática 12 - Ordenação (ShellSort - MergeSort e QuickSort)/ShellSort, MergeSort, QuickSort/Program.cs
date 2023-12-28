using System.Diagnostics;
using System.IO;
using System.Text;

namespace ShellSort__MergeSort__QuickSort;
class Program
{

        static int mediaComparacoesShell = 0, mediaMovimentacoesShell = 0;
       static  long mediaTempoShell = 0;
        static int mediaComparacoesMerge = 0, mediaMovimentacoesMerge = 0;
       static long mediaTempoMerge = 0;
        static int mediaComparacoesQuick = 0, mediaMovimentacoesQuick= 0;
        static long mediaTempoQuick = 0;
    static void Main(string[] args)
    {

        StreamWriter arquivo = new StreamWriter("relatório.txt", true, Encoding.UTF8);


        int[] array = new int[200000];

        Random aleatorios = new Random();

        for(int i = 0;  i < array.Length; i++){
            array[i] = aleatorios.Next(1, array.Length);
        }

        Shell(array, arquivo);
        Merge(array, arquivo);
        Quick(array, arquivo);

        arquivo.WriteLine("=================================================");
        arquivo.WriteLine("Vetor de tamanho: " + array.Length);
        arquivo.WriteLine("Média do tempo de execução da ShellSort: " + (mediaTempoShell/30));
        arquivo.WriteLine("Média das comparações da ShellSort: " + (mediaComparacoesShell/30));
        arquivo.WriteLine("Média das movimentações da ShellSort: " + (mediaMovimentacoesShell/30));
        arquivo.WriteLine("=================================================");

        arquivo.WriteLine("=================================================");
        arquivo.WriteLine("Vetor de tamanho: " + array.Length);
        arquivo.WriteLine("Média do tempo de execução da MergeSort: " + (mediaTempoMerge/30));
        arquivo.WriteLine("Média das comparações da MergeSort: " + (mediaComparacoesMerge/30));
        arquivo.WriteLine("Média das movimentações da MergeSort: " + (mediaMovimentacoesMerge/30));
        arquivo.WriteLine("=================================================");

        arquivo.WriteLine("=================================================");
        arquivo.WriteLine("Vetor de tamanho: " + array.Length);
        arquivo.WriteLine("Média do tempo de execução da QuickSort: " + (mediaTempoQuick/30));
        arquivo.WriteLine("Média das comparações da QuickSort: " + (mediaComparacoesQuick/30));
        arquivo.WriteLine("Média das movimentações da QuickSort: " + (mediaMovimentacoesQuick/30));
        arquivo.WriteLine("=================================================");

        arquivo.Close();
    }

    static void Shell(int[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
        int[] arrayCopia = (int[]) array.Clone();


        int comparacoesShell = 0, movimentacoesShell = 0;


        tempo.Start();

            int n = arrayCopia.Length;
            int h = 1;
            do {
                h = (h * 3) + 1;
                comparacoesShell+= 1;
            } while (h < n);
            do {
                h /= 3;
            for (int cor = 0; cor < h; cor++) {
                insercaoPorCor(cor, h);
            }
            comparacoesShell+= 1;
            } while (h != 1);
        

        void insercaoPorCor(int cor, int h) {
            for (int i = h + cor; i < arrayCopia.Length; i += h) {
                int tmp = arrayCopia[i];
                int j = i - h;
                while ((j >= 0) && (arrayCopia[j] > tmp)) {
                    arrayCopia[j + h] = arrayCopia[j];
                    movimentacoesShell+= 1;
                    comparacoesShell+= 1;
                    j -= h;
                }
                arrayCopia[j + h] = tmp;
                movimentacoesShell+= 1;
            }
        }

        tempo.Stop();

        arquivo.WriteLine("Método Shell ordenar: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesShell);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesShell);
        arquivo.WriteLine(" ");
        mediaTempoShell+= tempo.ElapsedMilliseconds;
        mediaComparacoesShell+= comparacoesShell;
        mediaMovimentacoesShell+= movimentacoesShell;
        cont+= 1;

        }while(cont < 10);

        cont = 0;

        do{
        teste += 1;



        int[] arrayCopia = (int[]) array.Clone();

        int comparacoesShell = 0, movimentacoesShell = 0;

            int n = arrayCopia.Length;
            int h = 1;
            do {
                h = (h * 3) + 1;
                comparacoesShell+= 1;
            } while (h < n);
            do {
                h /= 3;
            for (int cor = 0; cor < h; cor++) {
                insercaoPorCor(cor, h);
            }
            comparacoesShell+= 1;
            } while (h != 1);
        

        void insercaoPorCor(int cor, int h) {
            for (int i = h + cor; i < arrayCopia.Length; i += h) {
                int tmp = arrayCopia[i];
                int j = i - h;
                while ((j >= 0) && (arrayCopia[j] > tmp)) {
                    arrayCopia[j + h] = arrayCopia[j];
                    movimentacoesShell+= 1;
                    comparacoesShell+= 1;
                    j -= h;
                }
                arrayCopia[j + h] = tmp;
                movimentacoesShell+= 1;
            }
        }

        tempo.Start();

            do {
                h = (h * 3) + 1;
                comparacoesShell+= 1;
            } while (h < n);
            do {
                h /= 3;
            for (int cor = 0; cor < h; cor++) {
                insercaoPorCor2(cor, h);
            }
            comparacoesShell+= 1;
            } while (h != 1);
        

        void insercaoPorCor2(int cor, int h) {
            for (int i = h + cor; i < arrayCopia.Length; i += h) {
                int tmp = arrayCopia[i];
                int j = i - h;
                while ((j >= 0) && (arrayCopia[j] > tmp)) {
                    arrayCopia[j + h] = arrayCopia[j];
                    movimentacoesShell+= 1;
                    j -= h;
                    comparacoesShell+= 1;
                }
                arrayCopia[j + h] = tmp;
                movimentacoesShell+= 1;
            }
        }

        tempo.Stop();

        arquivo.WriteLine("Método ShellSort ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesShell);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesShell);
        arquivo.WriteLine("");
        mediaTempoShell+= tempo.ElapsedMilliseconds;
        mediaComparacoesShell+= comparacoesShell;
        mediaMovimentacoesShell+= movimentacoesShell;

        cont+= 1;

        }while(cont < 10);

        cont = 0;

        do{
        teste += 1;
        int[] arrayCopia = (int[]) array.Clone();

        

        int comparacoesShell = 0, movimentacoesShell = 0;

        tempo.Start();

            int n = arrayCopia.Length;
            int h = 1;
            do {
                h = (h * 3) + 1;
                comparacoesShell+= 1;
            } while (h < n);
            do {
                h /= 3;
            for (int cor = 0; cor < h; cor++) {
                insercaoPorCor(cor, h);
            }
            comparacoesShell+= 1;
            } while (h != 1);
    

        void insercaoPorCor(int cor, int h) {
            for (int i = h + cor; i < arrayCopia.Length; i += h) {
                int tmp = arrayCopia[i];
                int j = i - h;
                while ((j >= 0) && (arrayCopia[j] < tmp)) {
                    arrayCopia[j + h] = arrayCopia[j];
                    movimentacoesShell+= 1;
                    comparacoesShell+= 1;
                    j -= h;
                }
                arrayCopia[j + h] = tmp;
                movimentacoesShell+= 1;
            }
        }
        
        tempo.Stop();


        arquivo.WriteLine("Método ShellSort inversamente ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesShell);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesShell);
        arquivo.WriteLine("");
        cont+= 1;
        mediaTempoShell+= tempo.ElapsedMilliseconds;
        mediaComparacoesShell+= comparacoesShell;
        mediaMovimentacoesShell+= movimentacoesShell;

        }while(cont < 10);
    }

    static void Merge(int[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
        teste+= 1;

        

        int[] arrayCopia = (int[]) array.Clone();

        int comparacoesMerge = 0, movimentacoesMerge = 0, esq = 0, dir = arrayCopia.Length - 1;
        tempo.Start();

        MergeSort(arrayCopia, esq, dir);
        void MergeSort(int[] arrayCopia, int esq, int dir) {
            if (esq < dir) {
                comparacoesMerge+= 1;
                int meio = (esq + dir) / 2;
                MergeSort(arrayCopia, esq, meio);
                MergeSort(arrayCopia, meio + 1, dir);
                Intercala(arrayCopia, esq, meio, dir);
            }
        }

        void Intercala(int[] arrayCopia, int esq, int meio, int dir) {
            int n1 = meio - esq + 1;
            int n2 = dir - meio;
            int[] v_esq = new int[n1];
            int[] v_dir = new int[n2];

            for (int i = 0; i < n1; i++)
                v_esq[i] = arrayCopia[esq + i];

            for (int j = 0; j < n2; j++)
                v_dir[j] = arrayCopia[meio + 1 + j];

            int cont1 = 0, cont2 = 0;
            int k = esq;

            while (cont1 < n1 && cont2 < n2) {
                comparacoesMerge+= 1;
                if (v_esq[cont1] <= v_dir[cont2]) {
                    arrayCopia[k] = v_esq[cont1];
                    cont1++;
                    comparacoesMerge+= 1;
                    movimentacoesMerge+= 1;
                } else {
                    arrayCopia[k] = v_dir[cont2];
                    cont2++;
                    movimentacoesMerge+= 1;
                }
                k++;
            }

            while (cont1 < n1) {
                arrayCopia[k] = v_esq[cont1];
                cont1++;
                k++;
                comparacoesMerge+= 1;
                movimentacoesMerge+= 1;
            }

            while (cont2 < n2) {
                arrayCopia[k] = v_dir[cont2];
                cont2++;
                k++;
                comparacoesMerge+= 1;
                movimentacoesMerge+= 1;
            }
        }


        tempo.Stop();

        arquivo.WriteLine("Método MergeSort ordenar: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesMerge);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesMerge);
        arquivo.WriteLine("");
        mediaTempoMerge+= tempo.ElapsedMilliseconds;
        mediaComparacoesMerge+= comparacoesMerge;
        mediaMovimentacoesMerge+= movimentacoesMerge;

        cont+= 1;

        }while(cont < 10);

        

        cont = 0;

        do{
        teste+= 1;
        int[] arrayCopia = (int[]) array.Clone();
        

        int comparacoesMerge = 0, movimentacoesMerge = 0, esq = 0, dir = arrayCopia.Length - 1;

        MergeSort(arrayCopia, esq, dir);
        void MergeSort(int[] arrayCopia, int esq, int dir) {
            if (esq < dir) {
                comparacoesMerge+= 1;
                int meio = (esq + dir) / 2;
                MergeSort(arrayCopia, esq, meio);
                MergeSort(arrayCopia, meio + 1, dir);
                Intercala(arrayCopia, esq, meio, dir);
            }
        }

        void Intercala(int[] arrayCopia, int esq, int meio, int dir) {
            int n1 = meio - esq + 1;
            int n2 = dir - meio;
            int[] v_esq = new int[n1];
            int[] v_dir = new int[n2];

            for (int i = 0; i < n1; i++)
                v_esq[i] = arrayCopia[esq + i];

            for (int j = 0; j < n2; j++)
                v_dir[j] = arrayCopia[meio + 1 + j];

            int cont1 = 0, cont2 = 0;
            int k = esq;

            while (cont1 < n1 && cont2 < n2) {
                comparacoesMerge+= 1;
                if (v_esq[cont1] <= v_dir[cont2]) {
                    arrayCopia[k] = v_esq[cont1];
                    movimentacoesMerge+= 1;
                    cont1++;
                    comparacoesMerge+= 1;
                } else {
                    arrayCopia[k] = v_dir[cont2];
                    movimentacoesMerge+= 1;
                    cont2++;
                }
                k++;
            }

            while (cont1 < n1) {
                arrayCopia[k] = v_esq[cont1];
                movimentacoesMerge+= 1;
                cont1++;
                comparacoesMerge+= 1;
                k++;
            }

            while (cont2 < n2) {
                arrayCopia[k] = v_dir[cont2];
                movimentacoesMerge+= 1;
                cont2++;
                comparacoesMerge+= 1;
                k++;
            }
        }

        tempo.Start();

        MergeSort2(arrayCopia, esq, dir);

        void MergeSort2(int[] arrayCopia, int esq, int dir) {
            if (esq < dir) {
                comparacoesMerge+= 1;
                int meio = (esq + dir) / 2;
                MergeSort2(arrayCopia, esq, meio);
                MergeSort2(arrayCopia, meio + 1, dir);
                Intercala2(arrayCopia, esq, meio, dir);
            }
        }

        void Intercala2(int[] arrayCopia, int esq, int meio, int dir) {
            int n1 = meio - esq + 1;
            int n2 = dir - meio;
            int[] v_esq = new int[n1];
            int[] v_dir = new int[n2];

            for (int i = 0; i < n1; i++)
                v_esq[i] = arrayCopia[esq + i];

            for (int j = 0; j < n2; j++)
                v_dir[j] = arrayCopia[meio + 1 + j];

            int cont1 = 0, cont2 = 0;
            int k = esq;

            while (cont1 < n1 && cont2 < n2) {
                comparacoesMerge+= 1;
                if (v_esq[cont1] <= v_dir[cont2]) {
                    arrayCopia[k] = v_esq[cont1];
                    movimentacoesMerge+= 1;
                    cont1++;
                    comparacoesMerge+= 1;
                } else {
                    arrayCopia[k] = v_dir[cont2];
                    movimentacoesMerge+= 1;
                    cont2++;
                }
                k++;
            }

            while (cont1 < n1) {
                arrayCopia[k] = v_esq[cont1];
                movimentacoesMerge+= 1;
                comparacoesMerge+= 1;
                cont1++;
                k++;
            }

            while (cont2 < n2) {
                arrayCopia[k] = v_dir[cont2];
                movimentacoesMerge+= 1;
                comparacoesMerge+= 1;
                cont2++;
                k++;
            }
        }

        tempo.Stop();
        arquivo.WriteLine("Método MergeSort ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesMerge);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesMerge);
        arquivo.WriteLine("");
        mediaTempoMerge+= tempo.ElapsedMilliseconds;
        mediaComparacoesMerge+= comparacoesMerge;
        mediaMovimentacoesMerge+= movimentacoesMerge;
            
            cont+= 1;
        }while(cont < 10);

        cont = 0;

        do{
        teste+= 1;
        int[] arrayCopia = (int[]) array.Clone();

        int comparacoesMerge = 0, movimentacoesMerge = 0, esq = 0, dir = arrayCopia.Length - 1;

        

        tempo.Start();

        MergeSort(arrayCopia, esq, dir);
        void MergeSort(int[] arrayCopia, int esq, int dir) {
            if (esq < dir) {
                comparacoesMerge+= 1;
                int meio = (esq + dir) / 2;
                MergeSort(arrayCopia, esq, meio);
                MergeSort(arrayCopia, meio + 1, dir);
                Intercala(arrayCopia, esq, meio, dir);
            }
        }

        void Intercala(int[] arrayCopia, int esq, int meio, int dir) {
            int n1 = meio - esq + 1;
            int n2 = dir - meio;
            int[] v_esq = new int[n1];
            int[] v_dir = new int[n2];

            for (int i = 0; i < n1; i++)
                v_esq[i] = arrayCopia[esq + i];

            for (int j = 0; j < n2; j++)
                v_dir[j] = arrayCopia[meio + 1 + j];

            int cont1 = 0, cont2 = 0;
            int k = esq;

            while (cont1 < n1 && cont2 < n2) {
                comparacoesMerge+= 1;
                if (v_esq[cont1] >= v_dir[cont2]) {
                    arrayCopia[k] = v_esq[cont1];
                    cont1++;
                    comparacoesMerge+= 1;
                    movimentacoesMerge+= 1;
                } else {
                    arrayCopia[k] = v_dir[cont2];
                    cont2++;
                    movimentacoesMerge+= 1;
                }
                k++;
            }

            while (cont1 < n1) {
                arrayCopia[k] = v_esq[cont1];
                movimentacoesMerge+= 1;
                cont1++;
                k++;
                comparacoesMerge+= 1;
            }

            while (cont2 < n2) {
                arrayCopia[k] = v_dir[cont2];
                movimentacoesMerge+= 1;
                cont2++;
                k++;
                comparacoesMerge+= 1;
            }
        }

        tempo.Stop();

        arquivo.WriteLine("Método MergeSort inversamente ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesMerge);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesMerge);
        arquivo.WriteLine("");
        mediaTempoMerge+= tempo.ElapsedMilliseconds;
        mediaComparacoesMerge+= comparacoesMerge;
        mediaMovimentacoesMerge+= movimentacoesMerge;

        cont+= 1;

        }while(cont < 10);
    }


    static void Quick(int[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
            teste+= 1;
            int[] arrayCopia = (int[]) array.Clone();

            int movimentacoesQuick = 0, comparacoesQuick = 0;
            int esq = 0, dir = arrayCopia.Length - 1;
            tempo.Start();

            Quicksort(arrayCopia, esq, dir);
            
            void Quicksort(int[] arrayCopia, int esq, int dir) {
            int i = esq, j = dir, pivo = arrayCopia[(esq + dir) / 2];
            while (i <= j) {
                comparacoesQuick+= 1;
                while (arrayCopia[i] < pivo)
                    i++;
                    comparacoesQuick+= 1;
                while (arrayCopia[j] > pivo)
                    j--;
                    comparacoesQuick+= 1;
                if (i <= j) {
                    Trocar(i, j);
                    i++;
                    j--;
                    comparacoesQuick+= 1;
                }
            }
            if (esq < j)
                Quicksort(arrayCopia, esq, j);
                comparacoesQuick+= 1;
            if (i < dir)
                Quicksort(arrayCopia, i, dir);
                comparacoesQuick+= 1;
        }

            void Trocar(int i, int j){
                int temp = arrayCopia[i];
                arrayCopia[i] = arrayCopia[j];
                arrayCopia[j] = temp;
                movimentacoesQuick+= 1;
            }
            tempo.Stop();

        arquivo.WriteLine("Método QuickSort ordenar: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesQuick);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesQuick);
        arquivo.WriteLine("");
        mediaTempoQuick+= tempo.ElapsedMilliseconds;
        mediaComparacoesQuick+= comparacoesQuick;
        mediaMovimentacoesQuick+= movimentacoesQuick;

        cont+= 1;
        }while(cont < 10);

cont = 0;

        do{
        teste+= 1;
            int[] arrayCopia = (int[]) array.Clone();

            int movimentacoesQuick = 0, comparacoesQuick = 0;
            int esq = 0, dir = arrayCopia.Length - 1;

            Quicksort(arrayCopia, esq, dir);

            void Quicksort(int[] arrayCopia, int esq, int dir) {
            int i = esq, j = dir, pivo = arrayCopia[(esq + dir) / 2];
            while (i <= j) {
                comparacoesQuick+= 1;
                while (arrayCopia[i] < pivo)
                    i++;
                    comparacoesQuick+= 1;
                while (arrayCopia[j] > pivo)
                    j--;
                    comparacoesQuick+= 1;
                if (i <= j) {
                    Trocar(i, j);
                    i++;
                    j--;
                    comparacoesQuick+= 1;
                }
            }
            if (esq < j)
                Quicksort(arrayCopia, esq, j);
                comparacoesQuick+= 1;
            if (i < dir)
                Quicksort(arrayCopia, i, dir);
                comparacoesQuick+= 1;
        }

            void Trocar(int i, int j){
                int temp = arrayCopia[i];
                arrayCopia[i] = arrayCopia[j];
                arrayCopia[j] = temp;
                movimentacoesQuick+= 1;
            }

            tempo.Start();

            Quicksort2(arrayCopia, esq, dir);
            void Quicksort2(int[] arrayCopia, int esq, int dir) {
            int i = esq, j = dir, pivo = arrayCopia[(esq + dir) / 2];
            while (i <= j) {
                comparacoesQuick+= 1;
                while (arrayCopia[i] < pivo)
                    i++;
                    comparacoesQuick+= 1;
                while (arrayCopia[j] > pivo)
                    j--;
                    comparacoesQuick+= 1;
                if (i <= j) {
                    Trocar2(i, j);
                    i++;
                    j--;
                    comparacoesQuick+= 1;
                }
            }
            if (esq < j)
                Quicksort2(arrayCopia, esq, j);
                comparacoesQuick+= 1;
            if (i < dir)
                Quicksort2(arrayCopia, i, dir);
                comparacoesQuick+= 1;
        }

            void Trocar2(int i, int j){
                int temp = arrayCopia[i];
                arrayCopia[i] = arrayCopia[j];
                arrayCopia[j] = temp;
                movimentacoesQuick+= 1;
            }

            tempo.Stop();

        arquivo.WriteLine("Método QuickSort ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesQuick);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesQuick);
        arquivo.WriteLine("");
        mediaTempoQuick+= tempo.ElapsedMilliseconds;
        mediaComparacoesQuick+= comparacoesQuick;
        mediaMovimentacoesQuick+= movimentacoesQuick;

        cont+= 1;
        }while(cont < 10);

        cont = 0;

do{
        teste+= 1;
            int[] arrayCopia = (int[]) array.Clone();

            

            int movimentacoesQuick = 0, comparacoesQuick = 0;
            int esq = 0, dir = arrayCopia.Length - 1;

            tempo.Start();

                        Quicksort(arrayCopia, esq, dir);
            
            void Quicksort(int[] arrayCopia, int esq, int dir) {
            int i = esq, j = dir, pivo = arrayCopia[(esq + dir) / 2];
            while (i <= j) {
                comparacoesQuick+= 1;
                while (arrayCopia[i] < pivo)
                    i++;
                    comparacoesQuick+= 1;
                while (arrayCopia[j] > pivo)
                    j--;
                    comparacoesQuick+= 1;
                if (i <= j) {
                    Trocar(i, j);
                    i++;
                    j--;
                    comparacoesQuick+= 1;
                }
            }
            if (esq < j)
                Quicksort(arrayCopia, esq, j);
                comparacoesQuick+= 1;
            if (i < dir)
                Quicksort(arrayCopia, i, dir);
                comparacoesQuick+= 1;
        }

            void Trocar(int i, int j){
                int temp = arrayCopia[j];
                arrayCopia[j] = arrayCopia[i];
                arrayCopia[i] = temp;
                movimentacoesQuick+= 1;
            }

            tempo.Stop();

        arquivo.WriteLine("Método QuickSort inversamente ordenado: ");
        arquivo.WriteLine("Tempo de execução: " + tempo.ElapsedMilliseconds + " milissegundos");
        arquivo.WriteLine("Número de comparações: " + comparacoesQuick);
        arquivo.WriteLine("Número de movimentações: " + movimentacoesQuick);
        arquivo.WriteLine("");
        mediaTempoQuick+= tempo.ElapsedMilliseconds;
        mediaComparacoesQuick+= comparacoesQuick;
        mediaMovimentacoesQuick+= movimentacoesQuick;

        cont+= 1;
        }while(cont < 10);
    }

}


namespace alunos;
using System.Diagnostics;
using System.IO;
using System.Text;


class Alunos{
    private int matricula;
    private string nome;
    private string curso;
    private int rendimento;
    private int periodo;

    public Alunos(int matricula, string nome, string curso, int rendimento, int periodo){
        this.matricula = matricula;
        this.nome = nome;
        this.curso = curso;
        this.rendimento = rendimento;
        this.periodo = periodo;
    }

    public int Matricula{
        get {return matricula;}
        set {matricula = value;}
    }

    public string Nome{
        get {return nome;}
        set {nome = value;}
    }

    public string Curso{
        get {return curso;}
        set {curso = value;}
    }

    public int Rendimento{
        get {return rendimento;}
        set {rendimento = value;}
    }

    public int Periodo{
        get {return periodo;}
        set {periodo = value;}
    }


}
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

        Alunos alunos;

        Alunos[] array = new Alunos[10000];

        Random aleatorios = new Random();

        for(int i = 0; i < array.Length; i++){
            int matricula = aleatorios.Next(1, array.Length);
            string nome = GerarStringAleatoria(10);
            string curso = GerarStringAleatoria(10);
            int rendimento = aleatorios.Next(1, 10);
            int periodo = aleatorios.Next(1, 12);

            alunos = new Alunos(matricula, nome, curso, rendimento, periodo);

            array[i] = alunos;
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

        static string GerarStringAleatoria(int tamanho){

        const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder sb = new StringBuilder();

        Random random = new Random();
        for (int i = 0; i < tamanho; i++)
        {
            int index = random.Next(caracteres.Length);
            sb.Append(caracteres[index]);
        }

        return sb.ToString();
    }

    static void bolha(Alunos[] array, StreamWriter arquivo){

        Alunos alunos;

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
        Alunos[] arrayCopia = (Alunos[]) array.Clone();


        int comparacoesBolha = 0, movimentacoesBolha = 0;


        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length - 1; j > i; j--){
                comparacoesBolha++;
                if (arrayCopia[j].Matricula < arrayCopia[j-1].Matricula){
                    Alunos temp = arrayCopia[j];
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



        Alunos[] arrayCopia = (Alunos[]) array.Clone();

        int comparacoesBolha = 0, movimentacoesBolha = 0;

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length-1; j > i; j--){
                if (arrayCopia[j].Matricula < arrayCopia[j-1].Matricula){
                    Alunos temp = arrayCopia[j];
                    arrayCopia[j] = arrayCopia[j-1];
                    arrayCopia[j-1] = temp;
                    }
                }
            }

        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length-1; j > i; j--){
                comparacoesBolha++;
                if (arrayCopia[j].Matricula < arrayCopia[j-1].Matricula){
                    Alunos temp = arrayCopia[j];
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
        Alunos[] arrayCopia = (Alunos[]) array.Clone();

        

        int comparacoesBolha = 0, movimentacoesBolha = 0;

        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++){
            for (int j = arrayCopia.Length-1; j > i; j--){
                comparacoesBolha++;
                if (arrayCopia[j].Matricula > arrayCopia[j-1].Matricula){
                    Alunos temp = arrayCopia[j];
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

    static void selecao(Alunos[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
        teste+= 1;

        

        Alunos[] arrayCopia = (Alunos[]) array.Clone();

        int comparacoesSelecao = 0, movimentacoesSelecao = 0;

        tempo.Start();
        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                comparacoesSelecao++;
                if (arrayCopia[menor].Matricula > arrayCopia[j].Matricula){
                movimentacoesSelecao++;
                menor = j;
                }
            }
        Alunos temp = arrayCopia[menor];
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
        Alunos[] arrayCopia = (Alunos[]) array.Clone();
        

        int comparacoesSelecao = 0, movimentacoesSelecao = 0;

        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                if (arrayCopia[menor].Matricula > arrayCopia[j].Matricula){
                menor = j;
                }
            }
        Alunos temp = arrayCopia[menor];
        arrayCopia[menor] = arrayCopia[i];
        arrayCopia[i] = temp;
        }

        tempo.Start();

        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                comparacoesSelecao++;
                if (arrayCopia[menor].Matricula > arrayCopia[j].Matricula){
                movimentacoesSelecao++;
                menor = j;
                }
            }
        Alunos temp = arrayCopia[menor];
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
        Alunos[] arrayCopia = (Alunos[]) array.Clone();

        int comparacoesSelecao = 0, movimentacoesSelecao = 0;

        

        tempo.Start();
        for (int i = 0; i < (arrayCopia.Length - 1); i++) {
        int menor = i;
            for (int j = (i + 1); j < arrayCopia.Length; j++){
                comparacoesSelecao++;
                if (arrayCopia[menor].Matricula < arrayCopia[j].Matricula){
                movimentacoesSelecao++;
                menor = j;
                }
            }
        Alunos temp = arrayCopia[menor];
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

        static void insercao(Alunos[] array, StreamWriter arquivo){

        Stopwatch tempo = new Stopwatch();

        int cont = 0, teste = 0;

        do{
            teste+= 1;
            Alunos[] arrayCopia = (Alunos[]) array.Clone();

            

            int movimentacoesInsercao = 0, comparacoesInsercao = 0;

            tempo.Start();

            for (int i = 1; i < arrayCopia.Length; i++) {
                Alunos tmp = arrayCopia[i];
                int j = i - 1;
                comparacoesInsercao += 1;
                while ( (j >= 0) && (arrayCopia[j].Matricula > tmp.Matricula) ){
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
                    Alunos[] arrayCopia = (Alunos[]) array.Clone();

            

            int movimentacoesInsercao = 0, comparacoesInsercao = 0;

            for (int i = 1; i < arrayCopia.Length; i++) {
                Alunos tmp = arrayCopia[i];
                int j = i - 1;
                while ( (j >= 0) && (arrayCopia[j].Matricula > tmp.Matricula) ){
                arrayCopia[j + 1] = arrayCopia[j];
                j--;
                }
                arrayCopia[j + 1] = tmp;
                }

            tempo.Start();

            for (int i = 1; i < arrayCopia.Length; i++) {
                Alunos tmp = arrayCopia[i];
                int j = i - 1;
                comparacoesInsercao += 1;
                while ( (j >= 0) && (arrayCopia[j].Matricula > tmp.Matricula) ){
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
            Alunos[] arrayCopia = (Alunos[]) array.Clone();

            

            int movimentacoesInsercao = 0, comparacoesInsercao = 0;

            tempo.Start();

            for (int i = 1; i < arrayCopia.Length; i++) {
                Alunos tmp = arrayCopia[i];
                int j = i - 1;
                comparacoesInsercao += 1;
                while ( (j >= 0) && (arrayCopia[j].Matricula < tmp.Matricula) ){
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

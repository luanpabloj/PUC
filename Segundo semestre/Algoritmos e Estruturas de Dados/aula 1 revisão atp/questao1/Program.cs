namespace questao1;
class Program
{
    static void Main(string[] args)
    {
        
        int[] vect = new int[5];

        preencherVect(vect);
        int menor = procurarMenor(vect);
        Console.WriteLine("Posição do menor valor: " + menor);
        trocarPosicao(vect, menor);
        impressao(vect);

    }


    public static void preencherVect(int[] vect){

        Console.WriteLine("Digite 5 números para preencher o vetor");
        for(int i = 0; i < 5; i++){
            vect[i] = int.Parse(Console.ReadLine());
        }
    }

    public static int procurarMenor(int[] vect){

        int auxiliar = 0;
        int auxiliar2 = vect[0];

        for(int i = 0; i < 5; i++){
            if(vect[i] < auxiliar2){
                auxiliar2 = vect[i];

                auxiliar = i;
            }
        }

        return auxiliar;
        
    }

    public static void trocarPosicao(int[] vect, int menor){

        int auxiliar1 = vect[0];
        vect[0] = vect[menor];
        vect[menor] = auxiliar1;
         
    }

    public static void impressao(int[] vect){

        Console.Write("Números do vetor: ");
        for(int i = 0; i < 5; i++){
            Console.Write(vect[i] + ", ");
        }
    }


}


    
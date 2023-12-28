namespace questao1;
class Program
{
    static void Main(string[] args)
    {
        int[] vect = new int[5];
        int menu = 1;

        for(int i = 0; i < 5; i++){
            vect[i] = int.Parse(Console.ReadLine());
        }

        while(menu == 1){
        Console.WriteLine("Escolha as opções: \n1) Exibir maior valor\n2) Exibir menor valor\n3) Exibir média\n4) Sair");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao){
        case 1:
        maiorValor(vect);
        break;

        case 2:
        menorValor(vect);
        break;

        case 3:
        mediaValor(vect);
        break;

        case 4:
        menu = 0;
        break;

        }
        }

    }

    public static void menorValor(int[] vect){
        int auxi = 0;

        for(int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
                if(vect[i] < vect[j]){
                    auxi = vect[i];
                    vect[i] = vect[j];
                    vect[j] = auxi;
                }
            }
        }

        Console.WriteLine("menor valor: " + vect[0]);
    }

        public static void maiorValor(int[] vect){
        int auxi = 0;

        for(int i = 0; i < 5; i++){
            for(int j = 0; j < 5; j++){
                if(vect[i] > vect[j]){
                    auxi = vect[i];
                    vect[i] = vect[j];
                    vect[j] = auxi;
                }
            }
        }

        Console.WriteLine("maior valor: " + vect[0]);
    }

    public static void mediaValor(int[] vect){
        int auxi = 0;

        for(int i = 0; i < 5; i++){
            auxi+= vect[i];
        }



        Console.WriteLine("média: " + (auxi/5));
    }

}

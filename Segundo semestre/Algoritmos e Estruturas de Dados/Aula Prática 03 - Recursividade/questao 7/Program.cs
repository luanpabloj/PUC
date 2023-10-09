namespace questao_7;
class Program
{
    static void Main(string[] args)
    {
        int[] vect = new int[10];

        for(int i = 0; i < 10; i++){
            vect[i] = int.Parse(Console.ReadLine());
        }

        recursao(vect, 0, 9);

        Console.WriteLine("Elementos ordenados: ");
        for(int i = 0; i < 10; i++){
            Console.WriteLine(vect[i]);
        }

    }

    static void recursao(int[] vect, int auxi1, int auxi2){

        if(auxi1 < auxi2){
            int auxi3 = vect[auxi1];
            vect[auxi1] = vect[auxi2];
            vect[auxi2] = auxi3;

            recursao(vect, auxi1 + 1, auxi2 - 1);
        }
    }
}

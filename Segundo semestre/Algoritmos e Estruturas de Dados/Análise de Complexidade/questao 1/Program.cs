namespace Aula_Prática___Análise_de_Complexidade;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static void alternativaA(){

        for(int i = 0; i < n; i++){
            int a = a / 1;
            int b = b / 2;
            int c = c / 3;
            int d = d / 4;
            int e = e / 5;
        }
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                for(int l = 0; l < n; l++){
                    int a *= a;
                    int b *= b;
                    int c *= c;
                    int d *= d;
                }
            }
        }
    }

    static void alternativaB(){

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                for(int k = 0; k < n; k++){
                    for(int l = 0; l < n; l++){
                        int a += 1;
                        int b += 2;
                        int c += 3;
                        int d += 4;
                        int e += 5;
                        int f += 6;
                        int g += 7;
                        int h += 8;
                        int z += 9;
                    }
                }
            }
        }
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                int a += 1;
                int b += 2;
                int c += 3;
                int d += 4;
                int e += 5;
            }
        }

        for(int i = 0; i < n; i/=n){
            int a *= 1;
        }
    }

    static void alternativaC(){

        for(int i = 0; i < n; i++){
           for(int j = 0; j < n; j++){
            for(int k = 0; k < n; k++){
                int a += 1;
                int b += 2;
                int c += 3;
                int d += 4;
            }
           } 
        }

        int a += 1;
        int b += 2;
    }

    static void alternativaD(){
         for(int i = 0; i < n; i/=n){
            int a += 1;
         }
         for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                int a *= 1;
            }
         }
    }

    static void alternativaE(){
        for(int i = 0; i < n; i/=2){
            int a *= 1;
            int b *= 2;
            int c *= 3;
        }
        for(int i = 0; i < n; i/=2){
            int a *= 0;
        }
    }

    static void alternativaF(){
        for(int i = 0; i < n; i++){
            int a *= 1;
            int b *= 2;
        }
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                int a *= 1;
                int b *= 2;
            }
        }
        for(int i = 0; i < n; i/=2){
            int a *= 1;
        }
    }
}
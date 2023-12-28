int num=0, fatorial=1, y=1;


Console.WriteLine("Digite a quantidade de valores a ser lidos");
num = int.Parse(Console.ReadLine());

for(int i = 1; i <= num; i++){

    while(y <= num){
       
       fatorial *= y;

       Console.WriteLine("Número lido: " + i + " fatorial: " + fatorial);

        y++;
    }


}

double num=0, cont=0, s=0, menos=0, mais=0, y=1;

Console.WriteLine("Digite o valor de X ");
num = double.Parse(Console.ReadLine());


while(cont <= num){

    if(cont % 2 == 0){
        while(y <= cont){
        mais+= (Math.Pow(num, (1+cont)))/(num*y);

        y++;
        }
    }
    else{
         while(y <= cont){
        menos+= (Math.Pow(num, (1+cont)))/(num*y);

        y++;
         }
    }

    s = mais-menos;

    cont++;
}

Console.WriteLine(s);


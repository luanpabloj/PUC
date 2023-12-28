double s=0, numerador=2, de=1, num=0;


    Console.WriteLine("Digite o valor de X");
    num = int.Parse(Console.ReadLine());

do{

    s+= (numerador*num)/Math.Pow(de, de);


de++;
}

while(de <= 7);

Console.WriteLine(s);
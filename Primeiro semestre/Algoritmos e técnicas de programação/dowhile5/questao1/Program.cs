int num=0, cont=1;


do{
    Console.WriteLine("Digite um número inteiro");
    num = int.Parse(Console.ReadLine());

    if(num % 2 == 0){
        Console.WriteLine("Número não primo");
    }

    else{
        Console.WriteLine("Número primo");
    }

    cont++;
}
while(cont > 0);
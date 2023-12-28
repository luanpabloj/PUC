int ladoA=0, cont=1;
double area=0, altura=0;

do{
    Console.WriteLine("Digite o valor da base do triângulo: ");
    ladoA = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da altura do triângulo: ");
    altura = int.Parse(Console.ReadLine());


    if(ladoA >= 1){
        area = (ladoA*altura)/2;
        Console.WriteLine("Valor da área do triângulo: " + area);
    }
    else{
        Console.WriteLine("Valor inválido");
        break;
    }

cont++;
}

while(cont > 1);

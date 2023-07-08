double operarios=0, salariooperario=0, numoperario=0, pecasfabricadas=0, folhadepgt=0, totalpecasfab=0;
double sexom=0, sexof=0, pecasmasculinas=0, pecasfemininas=0;
int sexo=0;


while(operarios <= 15){

    Console.WriteLine("Digite o número do operário: ");
    numoperario = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o número de peças fabricadas: ");
    pecasfabricadas = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o sexo: (0 para masculino e 1 para feminino)");
    sexo = int.Parse(Console.ReadLine());

    if(sexo == 0){
        sexom++;
    }
    else{
        sexof++;
    }

    int classedooperario=0;

    if(pecasfabricadas <= 30){
        classedooperario = 1;
        salariooperario = 1000;
        if(sexo == 0){
        pecasmasculinas+= pecasfabricadas;
        }
        else{
            pecasfemininas+= pecasfabricadas;
        }
    }

    else if(pecasfabricadas >= 31 && pecasfabricadas <= 35){
        classedooperario = 2;
        salariooperario = 1000 + ((30-pecasfabricadas)*0.03*1000);
                if(sexo == 0){
        pecasmasculinas+= pecasfabricadas;
        }
        else{
            pecasfemininas+= pecasfabricadas;
        }
    }

    else{
        classedooperario = 3;
        salariooperario = 1000 + ((35-pecasfabricadas)*0.05*1000);
                if(sexo == 0){
        pecasmasculinas+= pecasfabricadas;
        }
        else{
            pecasfemininas+= pecasfabricadas;
        }
    }

Console.WriteLine("número do operário: " + numoperario + " salário: " + salariooperario);

folhadepgt = salariooperario++;
totalpecasfab = pecasfabricadas++;
pecasfemininas++;
pecasmasculinas++;





    operarios++;
}

Console.WriteLine("Folha de pagamento da fábrica: " + folhadepgt);
Console.WriteLine("Total de peças fabricadas no mês: " + pecasfabricadas);
Console.WriteLine("Peças fabricadas por homens: " + pecasmasculinas);
Console.WriteLine("Peças fabricadas pelas mulheres: " + pecasfemininas);
 
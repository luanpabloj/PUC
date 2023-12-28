int numSim=0, numNao=0, porcenFemiSim=0, porcenMascNao=0, feminino=0, masculino=0;
String simOuNao="", sexo="";

for(int i = 1; i <= 2000; i++){
    Console.WriteLine("Digite o sexo do entrevistado");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite a resposta do entrevistado (sim ou não)");
    simOuNao = Console.ReadLine();

    if(simOuNao == "sim"){
        numSim++;
    }
    else if(simOuNao == "nao"){
        numNao++;
    }

    if(sexo == "feminino"){
        feminino++;
        if(simOuNao == "sim"){
        numSim++;

        porcenFemiSim = feminino/numSim*100;

    }
    }
    
    if(sexo == "masculino"){
        masculino++;
        if(simOuNao == "nao"){
            numNao++;

            porcenMascNao = masculino/numNao*100;
        }
    }
}

Console.WriteLine("o número de pessoas que responderam sim: " + numSim);
Console.WriteLine("o número de pessoas que responderam não: " + numNao);
Console.WriteLine("a porcentagem de pessoas do sexo feminino que responderam sim: " + porcenFemiSim);
Console.WriteLine("a porcentagem de pessoas do sexo masculino que responderam não: " + porcenMascNao);
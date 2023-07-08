//Faça um programa para ler o código, o sexo (M-masculino, F-feminino) e o número de horas/aula dadas mensalmente
//pelos professores de uma universidade, sabendo-se que cada hora/aula vale R$ 30,00. Emita uma listagem contendo o
//código, o salário bruto e o salário líquido (levando em consideração os descontos explicados a seguir) de todos os
//professores. Mostre também a média dos salários líquidos dos professores do sexo masculino e a média dos salários líquidos
//dos professores do sexo feminino. Considere:
//- desconto para homens, 10% e, para mulheres, 5%;
//- as informações terminarão quando for lido o código = 99999

double codigo=0, numhorasmensalmente=0, sexom=0, sexof=0, salariobruto=0, salarioliquido=0, salarioliquidof=0, salariomediom=0, salariomediof=0, media=0;
String sexo=""; 



while(media < 99999){

Console.WriteLine("Digite o código do professor: ");
codigo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o sexo do professor: ");
sexo = Console.ReadLine();

Console.WriteLine("Digite a quantidade de horas dadas no mês: ");
numhorasmensalmente = double.Parse(Console.ReadLine());

if(codigo == 99999){
    break;
}

    else if(sexo == "m"){
        salariobruto = numhorasmensalmente*30;
        salarioliquido = (salariobruto*0.10)+salariobruto;

        Console.WriteLine("Codigo do professor: " + codigo + " salário bruto: " + salariobruto + " salario líquido" + salarioliquido);

        sexom++;


    }

    else{
        salariobruto = numhorasmensalmente*30;
        salarioliquidof = (salariobruto*0.05)+salariobruto;

        Console.WriteLine("Codigo do professor: " + codigo + " salário bruto: " + salariobruto + " salario líquido" + salarioliquidof);

        sexof++;

    }


media++;

salariomediom+= salarioliquido/media;
salariomediof+= salarioliquido/media;


}

Console.WriteLine("Média salarial líquido masculino: " + salariomediom + " salário líquido feminino: " + salarioliquidof);
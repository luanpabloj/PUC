int alunos=1, notas=0, notas2=0, mediaarit=0, aprovados=0, exame=0, reprovado=0, mediatotal=0;


while(alunos <= 6){

Console.WriteLine("Digite a primeira nota do aluno: " + alunos);
notas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota do aluno: " + alunos);
notas2 = int.Parse(Console.ReadLine());

mediaarit = (notas + notas2)/2;

    if(mediaarit <= 3){
        Console.WriteLine("Média: " + mediaarit + " situação: reprovado");
        reprovado++;
        

    }
    else if(mediaarit > 3 && mediaarit < 7){
        Console.WriteLine("Média: " + mediaarit + " situação: exame");
        exame++;
        
    }
    else{
        Console.WriteLine("Média: " + mediaarit + " situação: aprovado");
        aprovados++;
        
    }
    
    mediatotal+= mediaarit/6;

alunos++;



}

Console.WriteLine("Quantidade de alunos aprovados: " + aprovados);
Console.WriteLine("Quantidade de alunos reprovados: " + reprovado);
Console.WriteLine("Quantidade de alunos em fase de exame: " + exame);
Console.WriteLine("Média geral: " + mediatotal);


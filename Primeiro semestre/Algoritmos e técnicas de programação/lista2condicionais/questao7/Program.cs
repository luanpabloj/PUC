double salariomin=0, numhtrab=0, numDepen=0, quantExtra=0;

Console.WriteLine("Digite o salário mínimo");
salariomin = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas");
numhtrab = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de dependentes");
numDepen = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas extras trabalhadas");
quantExtra = double.Parse(Console.ReadLine());


double valortrab = salariomin/5;
double salariomes =  valortrab * numhtrab;
double valordepen = 32*numDepen;
double valorhoraExtra = numhtrab*(valortrab*1.50);
double salariobruto = salariomes + valordepen + valorhoraExtra;
double irrf=0;

if(salariobruto < 200){
    irrf = salariobruto*1;
}

else if(salariobruto >= 200 && salariobruto <= 500){
    irrf = salariobruto*0.10;
}

else{
    irrf = salariobruto*0.20;
}

double salarioliquido = salariobruto-irrf;
double gratificacao=0;

if(salarioliquido <= 350){
    gratificacao = 100;
}

else{
    gratificacao = 50;
}

double salarioareceber = salarioliquido + gratificacao;

Console.WriteLine("Salário do funcionário é de: " + salarioareceber);
int cont=0, opcao=0;
double salario=0, imposto=0, aumento=0;

while(cont <= 4){

    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("1. Imposto");
    Console.WriteLine("2. Novo salário");
    Console.WriteLine("3. Classificação");
    Console.WriteLine("4. Finalizar o programa");
    opcao = int.Parse(Console.ReadLine());

    if(opcao == 1){
        Console.WriteLine("Digite o salário do funcionário: ");
        salario = double.Parse(Console.ReadLine());

        if(salario < 1000){
            imposto = salario*0.05;
            Console.WriteLine("imposto: " + imposto);
        }
        else if(salario >= 1000 && salario < 2000){
            imposto = salario*0.10;
            Console.WriteLine("imposto: " + imposto);
        }
        else{
            imposto = salario*0.15;
            Console.WriteLine("imposto: " + imposto);
        }

    }

    else if(opcao == 2){
        Console.WriteLine("Digite o salário do funcionário: ");
        salario = double.Parse(Console.ReadLine());

        if(salario > 2000){
            aumento = salario+25;
            Console.WriteLine("novo salário: " +  aumento);
        }

        else if(salario >= 1500 && salario <= 2000){
            aumento = salario+50;
            Console.WriteLine("novo salário: " +  aumento);
        }

        else if(salario >= 1000 && salario < 1500){
            aumento = salario+75;
            Console.WriteLine("novo salário: " +  aumento);
        }

        else{
            aumento = salario+100;
            Console.WriteLine("novo salário: " +  aumento);
        }

    }

    else if(opcao == 3){
        Console.WriteLine("Digite o salário do funcionário: ");
        salario = double.Parse(Console.ReadLine());

        if(salario < 1000){
            Console.WriteLine("mal remunerado");
        }
        else{
            Console.WriteLine("bem remunerado");
        }
    }

    else{
        break;
    }



    cont++;
}

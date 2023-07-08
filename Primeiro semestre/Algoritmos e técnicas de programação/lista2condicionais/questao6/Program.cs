Console.WriteLine("Digite o código do cargo do funcionário");
int codigo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário do funcionário");
double salario = double.Parse(Console.ReadLine());

double aumento=0;

if(codigo == 1){
    aumento = salario*1.50;
    Console.WriteLine("Cargo do funcionário: Escrituário " + " e seu salário é " + aumento);
}

else if(codigo == 2){
    aumento = salario*1.35;
    Console.WriteLine("Cargo do funcionário: Secretário " + " e seu salário é " + aumento);
}

else if(codigo == 3){
    aumento = salario*1.20;
    Console.WriteLine("Cargo do funcionário: Caixa " + " e seu salário é " + aumento);
}

else if(codigo == 4){
    aumento = salario*1.35;
    Console.WriteLine("Cargo do funcionário: Gerente " + " e seu salário é " + aumento);
}

else{
    Console.WriteLine("Cargo do funcionário: Diretor " + " e seu salário é " + salario);
}
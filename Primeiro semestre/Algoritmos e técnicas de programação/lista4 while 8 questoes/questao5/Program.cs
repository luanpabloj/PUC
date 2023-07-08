double salariocarlos=0, salariojoao=0, meses=1;


Console.WriteLine("Digite o salário de Carlos");
salariocarlos = int.Parse(Console.ReadLine());

salariojoao = salariocarlos/3;


while(salariojoao < salariocarlos){

    salariocarlos+= salariocarlos*0.02;
    salariojoao+= salariojoao*0.5;


meses++;
}

Console.WriteLine("Meses necessários para que o valor pertencente a João iguale ou ultrapasse o valor pertencente a Carlos: " + meses);


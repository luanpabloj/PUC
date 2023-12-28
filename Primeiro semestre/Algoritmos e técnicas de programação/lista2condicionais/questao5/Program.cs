Console.WriteLine("Digite um número inteiro");
int inteiro = int.Parse(Console.ReadLine());

String npar="";

if(inteiro % 2 == 0){
    npar = "par";
    Console.WriteLine(npar);
}

else{
    npar = "impar";
    Console.WriteLine(npar);

}
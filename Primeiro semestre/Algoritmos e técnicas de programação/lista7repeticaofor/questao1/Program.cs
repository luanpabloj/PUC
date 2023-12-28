double v=0, p=0, codigo=0, transacao=0;

for(int i = 0; i <= 30; i++){
    Console.WriteLine("Digite o valor da transação");
    transacao = double.Parse(Console.ReadLine());

    if(transacao < 1000){
        v+= transacao;
    }
    
    else{
        p+= transacao;
    }
}


Console.WriteLine("o valor total das compras à vista: " + v);
Console.WriteLine(" valor total das compras a prazo: " + p);

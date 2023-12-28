int jogos=15, golsX=0, golsY=0, vitoriasX=0, vitoriasY=0, empate=0;
String maiorvencedor="";

for(int i = 1; i <= jogos; i++){
    Console.WriteLine("Números de gols marcados pelo time X na partida " + i);
    golsX = int.Parse(Console.ReadLine());
    Console.WriteLine("Números de gols marcados pelo time Y na partida " + i);
    golsY = int.Parse(Console.ReadLine());

    if(golsX > golsY){
        vitoriasX++;
    }
    else if(golsX < golsY){
        vitoriasY++;
    }

    else if(golsX == golsY){
        empate++;
    }

    if(vitoriasX > vitoriasY){
        maiorvencedor = "time X";
    }
    else if(vitoriasX < vitoriasY){
        maiorvencedor = "time Y";
    }
    else if(vitoriasX == vitoriasY){
        maiorvencedor = "não houve o maior vencedor";
    }
}

Console.WriteLine("O número de vitórias do time X: " + vitoriasX);
Console.WriteLine("O número de vitórias do time Y " + vitoriasY);
Console.WriteLine("O número de empates: " + empate);
Console.WriteLine("Uma mensagem indicando qual o time que venceu o maior número de duelos (ou não houve vencedor): " + maiorvencedor);
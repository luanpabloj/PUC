int n = 12, menor=0, maior=0, amaior=0, bmenor=0;
int[] temp = new int[n];
String[] mes = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};


for(int i = 0; i<n; i++){

    Console.WriteLine("Digite a temperatura do mês " + mes[i]);

    temp[i] = int.Parse(Console.ReadLine());
}


for(int i = 0; i<n; i++){
            if(temp[i] > temp[maior]){
            maior = i;
        }
}

for(int i = 0; i<n; i++){

        if(temp[i] < temp[menor]){
            menor = i;
        }
}



Console.WriteLine("Menor temperatura: " + temp[menor] + " ocorreu no mês: " + mes[menor]);
Console.WriteLine("Maior temperatura: " + temp[maior] + " ocorreu no mês: " + mes[maior]);
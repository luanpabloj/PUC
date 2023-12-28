Random random = new Random();


double[,] matriz = metodoMatriz();


condicao(matriz);






double[,] metodoMatriz(){


double[,] matriz = new double[10, 10];


for(int i = 0; i < 10; i++){
    for(int j = 0; j < 10; j++){
       
        matriz[i, j] = random.NextDouble();


    }
}



return matriz;
}



void condicao(double[,] matriz){



for(int i = 0; i < 10; i++){
    for(int j = 0; j < 10; j++){
       
        if(matriz[i, 0] < matriz[0, j]){
            matriz[i, j] = 2*i + 7*j - 2;
        }


        else if(matriz[i, 0] == matriz[0, j]){
            matriz[i, j] = 3*Math.Pow(i, 2) - 1;
        }


        else if(matriz[i, 0] > matriz[0, j]){
            matriz[i, j] = 4*Math.Pow(i, 3) - 5*Math.Pow(j, 2) + 1;


        }
    }
}


Console.WriteLine("Valores da matriz:");



for(int i = 0; i < 10; i++){
    for(int j = 0; j < 10; j++){
       
        Console.WriteLine(matriz[i, j]);


    }
}



}





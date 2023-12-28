int[] vetA = new int[8];
int[] vetB = new int[12];
int[] vetC = new int[20];

Console.WriteLine("Digite os valores para o vetor A");

for(int i = 0; i < 8; i++){
    vetA[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite os valores para o vetor B");

for(int i = 0; i < 12; i++){
    vetB[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < 20; i++){

vetC[i] = vetA[i];
vetA[i] = vetB[i];
vetB[i] = vetC[i];

}


for(int i = 0; i < 20; i++){
    Console.WriteLine("Valores de C: " + vetC[i]);
}


int baseMaior=0, baseMenor=0, altura=0, area=0;


Console.WriteLine("Digite a base maior, a base menor e a altura.");
baseMaior = int.Parse(Console.ReadLine());
baseMenor = int.Parse(Console.ReadLine());
altura = int.Parse(Console.ReadLine());

area = ((baseMaior + baseMenor)*altura)/2;

Console.WriteLine("A área do trapézio é: " + area);

Console.WriteLine("Luan Pablo Mendes Amaral");
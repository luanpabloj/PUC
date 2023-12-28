Console.WriteLine("Digite um número");
float x = float.Parse(Console.ReadLine());

int i=1;
float cal=0;

while(i <= 20){
cal+= (float)x/i;


i++;
}

Console.WriteLine(cal);
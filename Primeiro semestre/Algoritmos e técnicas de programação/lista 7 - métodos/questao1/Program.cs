Console.WriteLine("Digite o tempo em segudos");
int segundos = int.Parse(Console.ReadLine());

conversao(segundos);


void conversao(int segundos)
{
    int minutos = 0, horas = 0;

    minutos = segundos / 60;
    horas = minutos / 60;

    Console.WriteLine($"Horas: {horas}\nMinutos: {minutos}\nSegundos: {segundos}");

}

Console.WriteLine("Digite as medidas em pés");
double pes = double.Parse(Console.ReadLine());

double jarda=0, milha=0, polegada=0;

jarda = (pes*3)/3;
polegada = pes*12;
milha = jarda/1760;

Console.WriteLine("polegadas: {0}", polegada);
Console.WriteLine("jardas: {0}", jarda);
Console.WriteLine("milhas: {0}", milha);
Console.WriteLine("Luan Pablo Mendes Amaral");
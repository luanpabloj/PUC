double celsius = 0, fahrenheit = 0, c  = 0, f = 0;

Console.WriteLine("Digite uma temperatura em celsius");
celsius = double.Parse(Console.ReadLine());

Console.WriteLine("Digite uma temperatura em fahrenheit");
fahrenheit = double.Parse(Console.ReadLine());

celsiusParaFahrenheit(celsius, fahrenheit);
fahrenheitParaCelsius(celsius, fahrenheit);

void celsiusParaFahrenheit(double celsius, double fahrenheit)
{

    c = 5/9 * (fahrenheit - 32);

    Console.WriteLine($"Temperatura {celsius}C em fahrenheit: {c}");


}

void fahrenheitParaCelsius(double celsius, double fahrenheit)
{
    f = 9/5 * celsius + 32;

    Console.WriteLine($"Temperatura {fahrenheit}F em celsius: {f}");

}

//foi utilizado as fórmulas do PDF, e por acaso estão erradas!! Por isso está ocorrendo divergência nos resultados!!
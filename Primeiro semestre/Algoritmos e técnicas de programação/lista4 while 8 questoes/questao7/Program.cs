int idade = 0, sexoM = 0, sexoF = 0, temexperienciaM = 0, naotemexperienciaM = 0, temexperienciaF = 0, naotemexperienciaF = 0, idade45 = 0, idade21=0, idadeMMM=0, idadeMM=0, idadeFFF=0, idadeFF=0, cont=1;
String sexo = "", experiencia = "";
double porcentagemM=0, porcentagemF=0, idademediaMexperiencias=0, idademasculina=0, porcentagemmaisde45=0, idadefeminina=0, idademediaFexperiencias=0, porcentagemenosde21=0;


while (cont > 0)
{

Console.WriteLine("Digite a idade do funcionário: ");
idade = int.Parse(Console.ReadLine());
if(idade == 0){
    break;
}

    Console.WriteLine("Digite o sexo do funcionário: ");
    sexo = Console.ReadLine();


    if (sexo == "masculino" || sexo == "m")
    {
        idademasculina+= idade;
        sexoM++;

        Console.WriteLine("Digite se o funcionário tem experiência de serviço: ");
        experiencia = Console.ReadLine();

        if (idade >= 45)
        {
            idade45++;

            if (experiencia == "sim" || experiencia == "s")
            {
                temexperienciaM++;
                idadeMM+= idade;
                
            }

            else
            {
                naotemexperienciaM++;
            }
        }

        else
        {

            if (experiencia == "sim" || experiencia == "s")
            {
                temexperienciaM++;
                idadeMMM+= idade;

            }

            else
            {
                naotemexperienciaM++;
            }




        }


    }

        else{
        idadefeminina+= idade;
        sexoF++;

        Console.WriteLine("Digite se o funcionário tem experiência de serviço: ");
        experiencia = Console.ReadLine();

        if (idade <= 21)
        {
            idade21++;

            if (experiencia == "sim" || experiencia == "s")
            {
                temexperienciaF++;
                idadeMM+= idade;
            }

            else
            {
                naotemexperienciaF++;
                idadeMMM+= idade;
            }
        }

        else
        {

            if (experiencia == "sim" || experiencia == "s")
            {
                temexperienciaF++;
                idadeFF+= idade;

            }

            else
            {
                naotemexperienciaF++;
            }

        }


    }

cont++;

}

idademediaMexperiencias = (idadeMMM+idadeMM)/temexperienciaM;
porcentagemmaisde45 = (idade45*100)/sexoM;
idademediaFexperiencias = (idadeFFF+idadeFF)/temexperienciaF;
porcentagemenosde21 = (idade21*100)/sexoF;

Console.WriteLine("Número de candidatas: " + sexoF);
Console.WriteLine("Número de candidatos: " + sexoM);
Console.WriteLine("A idade média dos homens que já têm experiência no serviço: " + idademediaMexperiencias);
Console.WriteLine("A porcentagem dos homens com mais de 45 anos entre o total dos homens: " + porcentagemmaisde45);
Console.WriteLine("O número de mulheres com idade inferior a 21 anos e com experiência no serviço " + idademediaFexperiencias);


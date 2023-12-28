double parcelas=1, divida=0, valordivida=0, valorjuros=0, juros=0, valorparcela=0, cont=1, valorparcela2=0, resultado=0, resultado2=0;


Console.WriteLine("Digite o valor da dívida: ");
divida = double.Parse(Console.ReadLine());


while (parcelas <= 12)
{

if(parcelas % 3 == 0){
    if(parcelas == 3){
        juros = 0.10;
        valorjuros = divida * juros;
        valordivida = valorjuros + divida;
        while(cont <= 3){
            valorparcela = (valordivida*juros);
            resultado = (valorparcela+valordivida)*juros+valorparcela;
            resultado2 = (resultado+valordivida)*juros+resultado;
            cont++;
        }
        
    }

        else if(parcelas == 6){
                juros = 0.15;
        valorjuros = divida * juros;
        valordivida = valorjuros + divida;
        while(cont <= 6){
            valorparcela = (valordivida*juros);
            resultado = (valorparcela+valordivida)*juros+valorparcela;
            resultado2 = (resultado+valordivida)*juros+resultado;
            cont++;
        }
    }

    else if(parcelas == 9){
                juros = 0.20;
        valorjuros = divida * juros;
        valordivida = valorjuros + divida;
        while(cont <= 9){
            valorparcela = (valordivida*juros);
            resultado = (valorparcela+valordivida)*juros+valorparcela;
            resultado2 = (resultado+valordivida)*juros+resultado;
            cont++;
        }
    }
   
   else if(parcelas == 12){
                juros = 0.25;
        valorjuros = divida * juros;
        valordivida = valorjuros + divida;
        while(cont <= 12){
            valorparcela = (valordivida*juros);
            resultado = (valorparcela+valordivida)*juros+valorparcela;
            resultado2 = (resultado+valordivida)*juros+resultado;
            cont++;
        }
    }



Console.WriteLine("Valor da dívida: " + valordivida + " Valor do juros: " + valorjuros + " quantidade de parcelas: " + parcelas + " valor da parcela: " + resultado2);
}

    parcelas++;

}
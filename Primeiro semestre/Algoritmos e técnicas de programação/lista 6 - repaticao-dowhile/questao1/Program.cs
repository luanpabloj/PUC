int num=1, par=0, impar=0;


do{

    if(num % 2 == 0){
        par+= num;
    }

    else if(num % 2 != 0){
        impar+= num;
    }


    num++;

}
while(num <= 10);

    Console.WriteLine("Soma dos números pares: " + par);
    Console.WriteLine("Soma dos números impáres: " + impar);


    Console.WriteLine("Luan Pablo Mendes Amaral");
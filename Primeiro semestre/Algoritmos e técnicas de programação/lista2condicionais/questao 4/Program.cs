﻿Console.WriteLine("Digite três números diferentes");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if(num1 > num2 && num2 > num3){
    Console.WriteLine(num3+","+num2+","+num1);
}

else if(num3 > num2 && num2 > num1){
    Console.WriteLine(num1+","+num2+","+num3);
}

else if(num2 > num1 && num1 > num3){
    Console.WriteLine(num3+","+num1+","+num2);
}

else if(num2 > num3 && num3 > num1){
    Console.WriteLine(num2+","+num3+","+num1);
}







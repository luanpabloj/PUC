int i=2;
double cal=1;

while(i <= 99){

cal*= (1 - (1/Math.Pow(i, i)));

i++;

}


Console.WriteLine(cal);

Console.WriteLine("Number 1:");

int Num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Number 2:");
int Num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Number 3:");
int Num3 = int.Parse(Console.ReadLine());

if (Num1 < Num3 && Num2 < Num3)
{
    Console.WriteLine("Number 3 is biggest");
}
else if (Num1 < Num2 && Num2 > Num3)
{
    Console.WriteLine("Number 2 is biggest");
}
else if (Num1 > Num2 && Num1 > Num3)
{
    Console.WriteLine("Number 2 is biggest");
}
else if (Num1 == Num2 && Num3 == Num1) 
{
    Console.WriteLine("Numbers are equal");
}


else
    Console.WriteLine("Wrong");

Console.ReadLine();
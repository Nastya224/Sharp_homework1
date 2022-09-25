Console.Write("число a:");
string a = Console.ReadLine();
int number1 = int.Parse(a);

Console.Write("число b:");
string b = Console.ReadLine();
int number2 = int.Parse(b);

int max = number1;
int min = number2;
if (number2 >= max)
{
    max = number2;
     min = number1;
}
if (number2 < max)
{
    max = number1;
    min = number2;
}
Console.Write("max= ");
    Console.WriteLine(max);
Console.Write("min = ");
    Console.WriteLine(min);
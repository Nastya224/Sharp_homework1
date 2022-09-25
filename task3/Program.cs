Console.Write("число :");
string a = Console.ReadLine();
double number1 = double.Parse(a);

if (number1 % 2==0)
{
Console.Write(number1);
Console.WriteLine("-> да");
           
}
else
{
Console.Write(number1);
Console.WriteLine("-> нет");
}

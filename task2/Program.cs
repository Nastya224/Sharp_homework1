Console.Write("число 1:");
string a = Console.ReadLine();
int number1 = int.Parse(a);

Console.Write("число 2:");
string b = Console.ReadLine();
int number2 = int.Parse(b);

Console.Write("число 3:");
string c = Console.ReadLine();
int number3 = int.Parse(c);

int max = number1;
if (number2 >= max) max = number2;
if (number3 >= max) max = number3;
Console.Write("max= ");
    Console.WriteLine(max);
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());

int count = 1;

while (count <= N)
{
    if (count % 2==0)
    {Console.Write($"{count}"); 
    }
count = count+1;
}

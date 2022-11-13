Console.WriteLine("Введи первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число:");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.WriteLine($"{a}=max");
}
else
{
    Console.WriteLine($"{b}=max");
}




Console.WriteLine("Введи первое число:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число:");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи третье число:");
int C = int.Parse(Console.ReadLine()!);
if (A > B)
{
    if (A > C)
    {
        Console.WriteLine("Максимальное число: " + A);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + C);
    }
}

else if (B > C)
{
    Console.WriteLine("Максимальное число: " + B);
}
else
{
    Console.WriteLine("Максимальное число: " + C);
}




Console.WriteLine("Введи  число:");
int number = int.Parse(Console.ReadLine()!);
if (number % 2==0)
{
    Console.WriteLine("да");
}
else 
{
     Console.WriteLine("нет");
}



  Console.Write("Введите первое число: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
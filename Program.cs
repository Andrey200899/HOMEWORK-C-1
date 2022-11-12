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
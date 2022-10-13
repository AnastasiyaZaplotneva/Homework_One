// Напишите программу, которая на вход принимает число и выдает, является ли число четным

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number != 0)
{
    int remainder = number % 2;
    if(remainder != 0)
    {
        Console.WriteLine("Это число нечетное");
    }
    else
    {
        Console.WriteLine("Это число четное");
    }
}
else
{
    Console.WriteLine("Вы ввели 0");
}

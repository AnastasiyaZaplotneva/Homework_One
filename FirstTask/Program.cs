// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"Первое число больше второго, и оно равно {numberA}");
}
else if(numberB > numberA)
{
    Console.WriteLine($"Второе число больше первого, и оно равно {numberB}");
}
else
{
    Console.WriteLine("Числа равны");
}

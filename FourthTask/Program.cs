// Напишите программу, которая на вход принимает число N, а на выходе показывыает все четные числа от 1 до N включительно

Console.WriteLine("Введите положительное число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
if(number <= 0)
{
    Console.WriteLine("Вы ввели неверное число, запустите программу заново");
}
else
{
    while(count <= number)
    {
        int reminder = count % 2;
        if(reminder != 0)
        {
            count++;
        }
        else
        {
            Console.Write($"{count}. ");
            count++;
        }
    }
}
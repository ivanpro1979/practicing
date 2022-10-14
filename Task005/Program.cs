// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (x > 99 && x < 1000)
{
    Console.WriteLine("Последняя цифра числа: " + x % 10);
}
else
{
    Console.Write("Ошибка. Введите трехзначное число: ");
    int y = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (y > 99 && y < 1000) Console.WriteLine("Последняя цифра числа: " + y % 10);
}

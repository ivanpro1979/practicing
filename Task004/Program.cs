// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int count = -x;

while (count < x + 1)
{
    Console.Write(count + " ");
    count++;
}

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());

if(x > 0 && x < 8)
{
    if(x == 1) Console.WriteLine("Это понедельник");
    if(x == 2) Console.WriteLine("Это вторник");
    if(x == 3) Console.WriteLine("Это среда");
    if(x == 4) Console.WriteLine("Это четверг");
    if(x == 5) Console.WriteLine("Это пятница");
    if(x == 6) Console.WriteLine("Это суббота");
    if(x == 7) Console.WriteLine("Это воскресенье");
}
else
{
    Console.Write("Такого дня недели нет. Введите цифру от 1 до 7: ");
    int y = Convert.ToInt32(Console.ReadLine());
    if(y == 1) Console.WriteLine("Это понедельник");
    if(y == 2) Console.WriteLine("Это вторник");
    if(y == 3) Console.WriteLine("Это среда");
    if(y == 4) Console.WriteLine("Это четверг");
    if(y == 5) Console.WriteLine("Это пятница");
    if(y == 6) Console.WriteLine("Это суббота");
    if(y == 7) Console.WriteLine("Это воскресенье");

}
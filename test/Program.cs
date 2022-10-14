Console.Write("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

    switch(day)
    {
        case 1:
            Console.WriteLine("Это понедельник");
            break;
        case 2:
            Console.WriteLine("Это вторник");
            break;
        case 3:
            Console.WriteLine("Это среда");
            break;
        case 4:
            Console.WriteLine("Это четверг");
            break;
        case 5:
            Console.WriteLine("Это пятница");
            break;
        case 6:
            Console.WriteLine("Это суббота");
            break;
        case 7:
            Console.WriteLine("Это воскресенье");
            break;
        default:
            Console.WriteLine("Ошибка. Введите число от 1 до 7");
            break;
    }
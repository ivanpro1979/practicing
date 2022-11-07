namespace learn;
public class func
{
    // возвращает true, если введено целое число
    public static bool isNumber(string number)
    {
        bool result = int.TryParse(number, out int num);
        return result;
    }
}

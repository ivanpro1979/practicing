namespace learn;
public class func
{
    // возвращает true, если введено целое число
    public static bool isNumber(string number)
    {
        bool result = int.TryParse(number, out int num);
        return result;
    }

    public static int[] getRandomArray(int size, int x, int y)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(x, y);
        }
        return result;
    }
}

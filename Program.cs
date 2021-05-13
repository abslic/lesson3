using System;

public class Program
{
    static int CalcOddPositiveSum(int sum)
    {
        Console.Write("Введите числа (0 для выхода из программы): ");
        int num = int.Parse(Console.ReadLine());
        if (num == 0)
            return sum;
        if (num > 0 && num % 2 == 1)
            return CalcOddPositiveSum(num + sum);
        return CalcOddPositiveSum(sum);
    }

    public static void Main()
    {
        Console.WriteLine("Сумма положительных чисел: {0}\n", CalcOddPositiveSum(0));
        Console.ReadKey();
    }
}
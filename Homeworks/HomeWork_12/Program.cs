// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static HomeWork_12.Library;

int NumberDigits(int value)
{
    int i = 0;
    while (value >= 1)
    {
        value /= 10;
        i++;
    }
    return i;
}

int number = ReadNumber();
int n = NumberDigits(number);

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += (num / (int)Math.Pow(10, n - i - 1)) % 10;
    }
    return sum;
}

System.Console.WriteLine($"{number} -> {SumDigits(number)}");


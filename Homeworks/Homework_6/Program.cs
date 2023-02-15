// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

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

System.Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

int n = NumberDigits(a);

if (n <= 2)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    int t = (a / (int) Math.Pow(10, n - 3)) % 10;
    System.Console.WriteLine(a + " -> " + t);
}
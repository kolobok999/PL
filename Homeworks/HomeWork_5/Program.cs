// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int EnterNumber()
{
    while (true)
    {
        System.Console.WriteLine("Введите трёхзначное число");
        int value = int.Parse(Console.ReadLine());

        if (value >= 100 && value < 1000)
        {
            return value;
        }
        System.Console.WriteLine("Это не трехзначное число");
    }
}

int a = EnterNumber();

System.Console.WriteLine(a + " -> " + a / 10 % 10);
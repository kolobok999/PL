// 1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Write("Введите два числа: ");

int res = new Random().Next(10, 100);
int max = 0;
int a = res / 10;
int b = res % 10;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

System.Console.Write(res + " -> " + max);


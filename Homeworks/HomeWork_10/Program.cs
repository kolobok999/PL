// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using static HomeWork_10.Library;

void PrintCube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)}, ");
    }
}

int n = ReadNumber();
System.Console.Write($"{n} -> ");
PrintCube(n);
﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static Library.Library;

int F(int n)
{
    if (n == 1)
    {
        System.Console.Write($"{n}");
        return 1;
    }
    System.Console.Write($"{n}, ");
    return F(n - 1);
}
int n = ReadNumber();

F(n);
﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static Library.Library;

int LessSumOfElements(int[,] matrix)
{
    int k = 0;
    int less = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0)
        {
            less = sum;
        }
        else if (sum < less)
        {
            less = sum;
            k = i;
        }
    }
    return k;
}

int[,] matrix = new int[5, 6];
matrix = FillMatrix(matrix, 0, 10);
PrintMatrix(matrix);

System.Console.WriteLine($"Наименьшая сумма элементов в {LessSumOfElements(matrix) + 1}-й строке");


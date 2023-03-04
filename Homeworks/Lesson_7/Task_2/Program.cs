// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

using static Library.Library;

bool IsNumberInMatrix(int[,] matrix, int rows, int columns)
{
    return rows < matrix.GetLength(0) && columns < matrix.GetLength(1);
}

int[,] matrix = new int[3, 4];
matrix = FillMatrix(matrix, 0, 100);
PrintMatrix(matrix);

int rows = ReadNumber("Введите номер строки") - 1;
int columns = ReadNumber("Введите номер столбца") - 1;

if (IsNumberInMatrix(matrix, rows, columns))
{
    System.Console.WriteLine($"Matrix[{rows + 1},{columns + 1}] = {matrix[rows, columns]}");
}
else
{
    System.Console.WriteLine("Такого числа нет");
}
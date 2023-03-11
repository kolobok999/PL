// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static Library.Library;

int[,] orderRowsMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            for (int j = m; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, m])
                {
                    SwapMatrix(matrix, new int[] { i, j }, new int[] { i, m });
                }
            }
        }
    }
    return matrix;
}


int[,] matrix = new int[3, 4];
FillMatrix(matrix, 0, 20);
PrintMatrix(matrix);
System.Console.WriteLine();
matrix = orderRowsMatrix(matrix);
PrintMatrix(matrix);

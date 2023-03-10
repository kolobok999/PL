// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static Library.Library;

int m = ReadNumber();
int n = ReadNumber();

double [,] matrix = new double [m, n];

matrix = FillMatrix(matrix, -10, 10);

PrintMatrix(matrix);
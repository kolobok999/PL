// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static Library.Library;

double[] ArithmeticMeanInColumn(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] arithmeticMean = new double[columns];


    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            arithmeticMean[j] += matrix[i, j];
        }
        arithmeticMean[j] /= rows;
    }

    return arithmeticMean;
}

int[,] matrix = new int[3, 4];
matrix = FillMatrix(matrix, 0, 20);

PrintMatrix(matrix);

System.Console.WriteLine("________________________________________");
System.Console.WriteLine("Среднее Арифметическое каждого столбца \n" +
                    PrintArray(
                    ArithmeticMeanInColumn(matrix)));

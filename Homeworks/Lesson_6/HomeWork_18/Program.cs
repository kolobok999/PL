// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using static Library.Library;

double[] PointOfIntersection(int b1, int b2, int k1, int k2)
{
    double[] point = new double[2];
    point[0] = (double) (b2 - b1) / (k1 - k2);
    point[1] = (double)(k1 * b2 - k2 * b1) / (k1 - k2);
    return point;
}

int b1 = ReadNumber();
int k1 = ReadNumber();
int b2 = ReadNumber();
int k2 = ReadNumber();

System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
System.Console.WriteLine($"Точка пересечения прямых (y = k1 * x + b1) и (y = k2 * x + b2) = ( {PrintArray(PointOfIntersection(b1, b2, k1, k2))})");
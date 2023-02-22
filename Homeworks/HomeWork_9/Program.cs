// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using static Homework_9.Library;

double Distance(int[] a, int[] b)
{
    double dist = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2));
    return dist;
}

int[] a = { 3, 6, 8 };
int[] b = { 2, 1, -7 };
System.Console.Write("A ( ");
PrintArray(a);
Console.Write("); B ( ");
PrintArray(b);
Console.WriteLine(") -> " + Distance(a, b));
// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static HomeWork_11.Library;

int pow(int a, int b)
{
    int res = a;
    if (b == 0) return 1;
    for (int i = 1; i < b; i++)
    {
        res *= a;
    }
return res;
}

int a = ReadNumber();
int b = ReadNumber();
int p = pow(a, b);
System.Console.WriteLine($"{a}, {b} -> {p}");
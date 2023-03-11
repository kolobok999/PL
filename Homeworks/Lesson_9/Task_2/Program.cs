// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static Library.Library;

int sumOfNumberIter(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

int sumOfNumberRec(int a, int b) {
    int sum = 0;
    if (a == b) 
    {
        return b;
    }
    sum += a + sumOfNumberRec(a + 1, b);
    return sum;
}

int m = ReadNumber();
int n = ReadNumber();

System.Console.WriteLine($"M = {m}; N = {n} -> {sumOfNumberIter(m, n)}");
System.Console.WriteLine($"M = {m}; N = {n} -> {sumOfNumberRec(m, n)}");
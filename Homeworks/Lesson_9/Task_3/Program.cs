// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
//           {n + 1                     m = 0
// A(m, n) = {A(m - 1 , 1)              m > 0, n = 0
//           {A(m - 1, A(m, n - 1)),    m > 0, n > 0
using static Library.Library;

int Akkerman(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = Akkerman(m, n - 1);
        m = m - 1;
    }
    return n + 1;
}

int m = ReadNumber();
int n = ReadNumber();
System.Console.WriteLine(Akkerman(m, n));

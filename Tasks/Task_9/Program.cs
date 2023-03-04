// A=2
// B=9

// A<B, A, B - натуральные числа

// k1 = x2
// k2 = +1

// Найти количество комбинаций "превращения" числа А в число B.

// ** Показать(вывести на экран) один из способов такого "превращения"

// GetWays(2, 9) => 5
// GetWays(2, 11) => 7

// int f(int n)
// {
//   if (n == 2) return 1;
//   else if (n % 2 == 0) return f(n - 1) + f(n / 2);
//   else return f(n - 1);
// }

using static Library.Library;
int WayCount(int count, int a, int b)
{
    int k1 = a + 1;
    int k2 = a * 2;
    
    if (k2 <= b)
        System.Console.WriteLine($"k1 = {k1}, k2 = {k2}");
    else
        System.Console.WriteLine($"k1 = {k1}");

    if (k1 < b)
        count = WayCount(count, k1, b);
    else if (k1 == b)
        count++;

    if (k2 < b)
        count = WayCount(count, k2, b);
    else if (k2 == b)
        count++;
    return count;
}

int GetWays(int a, int b)
{
    int count = 0;
    count = WayCount(count, a, b);
    return count;
}

int a = ReadNumber();
int b = ReadNumber();
int wayCount = GetWays(a, b);
System.Console.WriteLine(wayCount);
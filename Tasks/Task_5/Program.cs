// 5 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите два числа:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if ((a * a) == b || (b * b) == a)
    System.Console.WriteLine(a + ", " + b + " -> да");
else
    System.Console.WriteLine(a + ", " + b + " -> нет");
// Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
using static HomeWork_13.Library;

int n = ReadNumber();
int [] array = new int[n];

WriteArray(array, 1, 100);

System.Console.WriteLine($"[ {PrintArray(array)}]");
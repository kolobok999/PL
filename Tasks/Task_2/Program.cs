// 2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int value = new Random().Next(100, 1000);
int res = (value / 100) * 10 + (value % 10);

System.Console.WriteLine(value + " -> " + res);
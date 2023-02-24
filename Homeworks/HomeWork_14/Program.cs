// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
using static Library.Library;

int EvenNumberCounter(int[] arr) //
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = new int[20];
WriteArray(array, 100, 1000);

System.Console.WriteLine($"[ {PrintArray(array)}] -> {EvenNumberCounter(array)}");


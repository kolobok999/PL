// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using static Library.Library;

int DiffBetwinMaxAndMinElem(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

int[] array = new int[5];
WriteArray(array);

System.Console.WriteLine($"[ {PrintArray(array)}] -> {DiffBetwinMaxAndMinElem(array)}");

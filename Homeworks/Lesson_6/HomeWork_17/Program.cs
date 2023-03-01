// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

using static Library.Library;

int CounterPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void FillArrayFromConsole(int [] arr) {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadNumber();
    }
}

int m = ReadNumber("Введите размерность массива");
int[] array = new int[m];
FillArrayFromConsole(array);

System.Console.WriteLine($"[ {PrintArray(array)}] -> {CounterPositiveNumbers(array)}");
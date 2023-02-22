// Сортировка массива методом выбора
using static Example_007.Library;

int[] Sort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int min = arr[i];
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] < min)
            {
                min = arr[j];
                Swap(arr, j, i);
            }
        }
    }
    return arr;
}

int[] array = new int[30];

WriteArray(array, 0, 100);
PrintArray(array);

array = Sort(array);
System.Console.WriteLine();
PrintArray(array);
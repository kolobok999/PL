// дан массив: наполнени числами от 1 до N
// Задача: сколько раз какое число встречается

// 1 3 1 2 1 2 4 5 1 2 5 4

// 1 - 4р
// 2 - 3р
// 3 - 1р
// 4 - 2р
// 5 - 2р
using static Task_8.Library;

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

int[] array = new int[20];
int[] counter = new int[20];

WriteArray(array, 0, 20);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    counter[array[i]]++;
}
System.Console.WriteLine();
Sort(arr: array);
for (int i = 0; i < counter.Length; i++)
{
    if (counter[array[i]] > 0)
    System.Console.WriteLine(array[i] + " -> " + counter[array[i]]);
}






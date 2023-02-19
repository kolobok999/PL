// Реализовать перемешивание массива

using static Task_7.Library;


int[] array = new int[30];

WriteArray(array, 1);
PrintArray(array);

for (int i = 0; i < array.Length / 2; i++)
{
    if (i % 2 == 0)
    {
        Swap(array, i, array.Length - i - 1);
    }
}


PrintArray(array);

// дан массив: наполнени числами от 1 до N
// Задача: сколько раз какое число встречается

// 1 3 1 2 1 2 4 5 1 2 5 4

// 1 - 4р
// 2 - 3р
// 3 - 1р
// 4 - 2р
// 5 - 2р
using static Task_8.Library;

int[] array = new int[30];
int[] counter = new int[100];

WriteArray(array, 0, 20);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    counter[array[i]]++;
}
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i] + " -> " + counter[array[i]]);
}






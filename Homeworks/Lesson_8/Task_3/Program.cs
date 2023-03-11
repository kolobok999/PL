// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Fill3dArray(int[,,] array3d)
{
    int size = array3d.GetLength(0) *
               array3d.GetLength(1) *
               array3d.GetLength(2);
    int[] repeat = new int[size];
    int count = 0;
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                bool find = false;
                while (true)
                {
                    int rand = new Random().Next(10, 100);
                    if (!find)
                    {
                        for (int r = 0; r < size; r++)
                        {
                            if (repeat[r] == rand) break;
                            else if (r != size - 1) continue;
                            array3d[i, j, k] = rand;
                            repeat[count] = rand;
                            count++;
                            find = true;
                        }
                    }
                    else break;
                }
            }
        }
    }
    return array3d;
}

void Print3dArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                System.Console.Write($"{array3d[j, k, i]}({j}, {k}, {i}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] array3d = new int[3, 3, 3];
Fill3dArray(array3d);
Print3dArray(array3d);
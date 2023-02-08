int [] mas = new int[10];

for (int i = 0; i < 10; i++) {
    mas[i] = new Random().Next(1, 10);
    Console.Write(mas[i] + " ");
}

int max = mas[0];

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > max)
    {
        max = mas[i];
    }
}

Console.WriteLine("\n" + "Максимальное число: " + max);
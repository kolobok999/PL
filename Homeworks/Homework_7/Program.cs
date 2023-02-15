// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int DayNumber()
{
    int dayNum;
    while (true)
    {
        try
        {

            System.Console.WriteLine("Введите число дня недели");
            dayNum = int.Parse(Console.ReadLine());

            if (dayNum > 7 || dayNum < 1)
            {
                System.Console.WriteLine("День недели введён неверно \n");
            }
            else return dayNum;
        }
        catch
        {
            System.Console.WriteLine("Это не число!!! \n");
        }
    }
}

int day = DayNumber();

if (day > 5)
{
    System.Console.Write(day + " -> Выходной");
}
else
{
    System.Console.Write(day + " -> Рабочий");
}


Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.Write("+");
int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("+");

Console.SetCursorPosition(xb, yb);
Console.Write("+");

Console.SetCursorPosition(xc, yc);
Console.Write("+");

int x = xa, y = xb;

for (int i = 0; i < 10000; i++)
{
    int rand = new Random().Next(0, 3);

    if (rand == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (rand == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (rand == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
}
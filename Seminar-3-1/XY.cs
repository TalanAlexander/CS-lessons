// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void printQuarter(int a, int b)
{
    if (a > 0 && b > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else if (a < 0 && b > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    else if (a < 0 && b < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    else if (a > 0 && b < 0)
    {
        Console.WriteLine("Четвертая четверть");
    }
    else
    {
        Console.WriteLine("Определить четверть невозможно");
    }
}


int returnQuarter(int a, int b)
{
    if (a > 0 && b > 0)
    {
        return 1;
    }
    else if (a < 0 && b > 0)
    {
        return 2;
    }
    else if (a < 0 && b < 0)
    {
        return 3;
    }
    else if (a > 0 && b < 0)
    {
        return 4;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine("Введите координаты x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());



printQuarter(x, y);

// Console.WriteLine(returnQuarter(x, y));

// int quarter = returnQuarter(x, y);
// Console.WriteLine($"Четверть: {quarter}");


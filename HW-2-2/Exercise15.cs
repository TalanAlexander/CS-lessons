//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
while(true)
{
    Console.Clear();

    int value;
    try
    {
        System.Console.WriteLine("Введите номер дня: ");
        value = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        System.Console.WriteLine("Постарайтесь ввести ТОЛЬКО цифры!)");
        Console.ReadLine();
        continue;
    }

    if (value <= 0)
    {
        System.Console.WriteLine("Это не подходит :)\nнажмите Enter");
        Console.ReadLine();
        continue;
    }

    System.Console.WriteLine(weekEnd(normalizeValue(value)));

    Console.ReadLine();
    break;
}

static int normalizeValue (int Day)
{
    int numberOfDay;
    if (Day % 7 == 0)
    {
        numberOfDay = 7;
    }
    else
    {
        if (Day > 7)
        {
            numberOfDay = Day - (Day / 7) * 7;
        }
        else
        {
            numberOfDay = Day;
        }
    }

    return numberOfDay;
}

static string weekEnd (int numer)
{
    string weekEnd;

    if (numer == 6 || numer == 7)
    {
        weekEnd = $"День выходной, {numer}-й";

    }
    else
    {
        weekEnd = $"Рабочий день, номер - {numer}";
    }

    return weekEnd;
}
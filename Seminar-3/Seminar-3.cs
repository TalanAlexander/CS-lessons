// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine() ?? "");

if (quarter == 1)
{
    Console.WriteLine("в первой четверти x > 0, y > 0");
}

if (quarter == 2)
{
    Console.WriteLine("во второй четверти x < 0, y > 0");
}

if (quarter == 3)
{
    Console.WriteLine("в третьей четверти x < 0, y < 0");
}

if (quarter == 4)
{
    Console.WriteLine("в четвёртой четверти x > 0, y < 0");    
}

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Введены некорректные данные");
}

System.Console.WriteLine("Press Enter");
Console.ReadLine();

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
quarter = int.Parse(Console.ReadLine() ?? "");

switch (quarter)
{
    case 1:
    {
        Console.WriteLine("x>0 y>0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x<0 y>0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x<0 y<0");
        break;
    }
    case 4:
    {
        Console.WriteLine("x>0 y<0");
        break;
    }

    default:
    {
        Console.WriteLine("Введена неправильная четверть");
        break;
    }
}

System.Console.WriteLine("Press Enter");
Console.ReadLine();


//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");

for(int i = 1; i <= N; i++)
{
    Console.Write($"{i*i} ");
}

System.Console.WriteLine("Press Enter");
Console.ReadLine(); 
//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

Console.Clear();
Console.Write("Введите X1: ");
int x1=int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите Y1: ");
int y1=int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите X2: ");
int x2=int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите Y2: ");
int y2=int.Parse(Console.ReadLine() ?? "");

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

Console.WriteLine($"d = {d:f3}");

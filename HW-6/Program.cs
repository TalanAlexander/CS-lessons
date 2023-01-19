// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] numbers = GetSomeNumbers();
ShowArray(numbers);
GetCountPositiveNumbers(numbers);

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] GetSomeNumbers()
{
    System.Console.WriteLine("Введите число элементов (М): ");
    int m = int.Parse(Console.ReadLine()??"0");

    int [] arr = new int[m];

    for (int i = 0; i < m; i++)
    {
        System.Console.WriteLine("Введите {0}-й элемент: ", i+1);
        arr[i] = int.Parse(Console.ReadLine()??"0");
    }

    return arr;
}

void GetCountPositiveNumbers(int [] numArray)
{
    int count = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if (numArray[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine("Во введённом массиве, число чисел > 0: {0}", count);
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = GetEquation("k1");
double b1 = GetEquation("b1");
double k2 = GetEquation("k2");
double b2 = GetEquation("b2");

GetIntersectionPoint(k1, b1, k2, b2);

void GetIntersectionPoint (double k1, double b1, double k2, double b2)
{
    double k = k1 - k2;
    double b = b2 - b1;
    if (k == 0)
    {
        System.Console.WriteLine("Пересечения нет");
    }
    else
    {
        double x = b/k;
        double y = k1 * x + b1;
        System.Console.WriteLine("Точка пересечения {0:f4}, {1:f4}", x, y);
    }
}

double GetEquation (string str)
{
    System.Console.WriteLine("Введите {0}: ", str);
    return double.Parse(Console.ReadLine()??"0");
}
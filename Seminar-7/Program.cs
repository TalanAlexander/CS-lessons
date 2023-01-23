// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()??"0");

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()??"0");

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Get48Array(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

int [,] SquareArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i+=2)
    {
        for (int j = 0; j < inArray.GetLength(1); j+=2)
        {
            inArray [i,j] = inArray[i,j] * inArray[i,j];
        }
    } 
    return inArray;
}

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()??"0");

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()??"0");

// int[,] array = Get48Array(rows, columns, 0, 10);
// PrintArray(array);

// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()??"0");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
PrintArray(SquareArray(array));


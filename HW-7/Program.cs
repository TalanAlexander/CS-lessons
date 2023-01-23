//  Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()??"0");

double[,] array47 = GetDoubleMatrix(rows, columns, 0, 10); 
PrintDoubleMatrix(array47);

//  Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] array50 = GetRandomIntArray();
PrintArray(array50);
System.Console.WriteLine("Введите номер колонки и строки, через запятую: ");
int [] arrayPosition = GetArrayFromStrings(Console.ReadLine());

if (arrayPosition[0] <= array50.GetLength(1) && arrayPosition[1] <= array50.GetLength(0))
{
    System.Console.WriteLine("Значение элемента: {0}", array50[arrayPosition[1] - 1, arrayPosition[0] - 1]);
}
else
{
    System.Console.WriteLine("Такой позиции в массиве нет!");
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.0

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()??"0");

int[,] array = GetIntArray(rows, columns, 0, 10);
PrintArray(array);
double[] res = GetAverageColumns(array);
PrintDoubleArray(res);

int[,] GetIntArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double[] GetAverageColumns(int [,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j] = result[j] + (double)inArray[i, j] / (double)inArray.GetLength(0);
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
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintDoubleArray(double[] inArray)
{
        for (int j = 0; j < inArray.Length; j++)
        {
            Console.Write($"{inArray[j]:f3}\t");
        }
}

int [,] GetRandomIntArray()
{
    Random rnd = new Random();
    int column = rnd.Next(2, 20);
    int rows = rnd.Next(2, 20);
    int min = 0;
    int max = rnd.Next(100);

    int [,] result = GetIntArray(rows, column, min, max);
    return result;
}

int [] GetArrayFromStrings(string stringArray)
{
    char[] charSeparators = new char[] {',','.',' '};
    string [] numStr = stringArray.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
    int [] result = new int[numStr.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result [i] = int.Parse(numStr[i]);
    }
    return result;
}

void PrintDoubleMatrix(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f3}\t");
        }
        System.Console.WriteLine();
    }
}

double [,] GetDoubleMatrix(int m, int n, int minValue, int maxValue)
{
    double [,] result = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.NextDouble() + rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}
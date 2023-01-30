// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array54 = GetRandomIntArray();
PrintArray(array54);
System.Console.WriteLine();
array54 = SortArray(array54);
PrintArray(array54);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,] array56 = GetRandomIntArray();
PrintArray(array56);
int [] rowSum = new int [array56.GetLength(0)];
rowSum = RowSum(array56);
ShowArray(rowSum);
System.Console.WriteLine("Строка с наименьшей суммой элементов: {0}", FindMinimumInArray(rowSum));

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

System.Console.WriteLine("Введите число строк первой матрицы: ");
int sizeL = int.Parse(Console.ReadLine()??"0");
System.Console.WriteLine("Введите число столбцов первой матрицы (и строк второй матрицы): ");
int sizeM = int.Parse(Console.ReadLine()??"0");
System.Console.WriteLine("Введите число столбцов второй матрицы: ");
int sizeN = int.Parse(Console.ReadLine()??"0");

int [,] arrayA = GetIntArray(sizeL, sizeM, 0, 25);
int [,] arrayB = GetIntArray(sizeM, sizeN, 0, 25);
int [,] arrayC = MultiplexMatrix(arrayA, arrayB);
System.Console.WriteLine();
PrintArray(arrayA);
System.Console.WriteLine();
PrintArray(arrayB);
System.Console.WriteLine();
System.Console.WriteLine("Результат умножения:");
PrintArray(arrayC);
System.Console.WriteLine();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array60 = GetTripleArray(4,4,4,10,90);
PrintTripleArray(array60);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
System.Console.WriteLine("Введите размер двухмерного массива через пробел: ");
int [] arraySize = GetArrayFromStrings(Console.ReadLine()??"0");
int[,] array62 = GetSpiralArray(arraySize[0], arraySize[1]);
PrintArray(array62);

int [,] GetRandomIntArray()
{
    Random rnd = new Random();
    int column = rnd.Next(2, 8);
    int rows = rnd.Next(2, 8);
    int min = 0;
    int max = rnd.Next(100);

    int [,] result = GetIntArray(rows, column, min, max);
    return result;
}

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

int [,,] GetTripleArray(int m, int n, int o, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, o];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int k = 0;
            while(k < o)
            {
                int numb = rnd.Next(minValue, maxValue + 1);
                if (SearchNumber(result, numb))
                {
                    continue;
                }
                result[i, j, k] = numb;
                k++;
            }
        }
    }
    return result;
}

bool SearchNumber(int[,,] inArray, int number)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                if (inArray[i, j, k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintTripleArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i,j,k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int [,] MultiplexMatrix(int [,] matrixA, int [,] matrixB)
{
    int [,] result = new int [matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result[i, j] = result [i,j] + matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return result;
}

int [,] SortArray (int [,] inArray)
{
   // int [,] result = new int [inArray.GetLength(0),inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - j - 1; k++)
            {
            if (inArray[i, k] < inArray[i, k + 1])
                {
                    int temp = inArray[i, k];
                    inArray[i, k] = inArray[i, k + 1];
                    inArray[i, k + 1] = temp;
                }
            }
        }
    }
    return inArray;
}

int [] RowSum(int [,] inArray)
{
    int [] result = new int [inArray.GetLength(0)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i] += inArray[i,j];
        }
    }
    return result;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindMinimumInArray(int [] inArray)
{
    int min = inArray[0];
    int result = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] < min)
        {
            min = inArray[i];
            result = i;
        }
    }
    return result + 1;
}

int [,] GetSpiralArray (int rows, int columns)
{
    int [,] result = new int [rows, columns];
    int numStep = 1;
    int circle = rows <= columns ? rows/2 : columns/2;
    int punk = (rows % 2 == 0 && columns % 2 == 0) ? 0 : 1;

    for (int j = 0; j < circle; j++)
    {
        for (int i = 0 + j; i < columns - j; i++)
        {
            result [j, i] = numStep;
            numStep ++;
        }

        for (int i = 1 + j; i < rows - j; i++)
        {
            result [i, columns - 1 - j] = numStep;
            numStep++;
        }

        for (int i = columns - 2 - j; i >= 0 + j; i--)
        {
            result [rows - 1 - j, i] = numStep;
            numStep++;
        }

        for (int i = rows - 2 - j; i >= 1 + j; i--)
        {
            result [i, j] = numStep;
            numStep++;
        }
    }

    if (punk == 1)
    {
        if (rows == columns)
        {
            result [rows / 2, columns  / 2] = numStep;
        }
        else
        {
            if (rows > columns)
            {
                for (int i = circle; i < rows - circle; i++)
                {   
                    result [i, columns / 2] = numStep;
                    numStep++; 
                }
            }
            else
            {
                for (int i = circle; i < columns - circle; i++)
                {
                    result [rows / 2, i] = numStep;
                    numStep++;
                }
            }
        }
    }
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
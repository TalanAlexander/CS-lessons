System.Console.Clear();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] Array34 = CreateRandomArray(25, 100, 999);
int evenNum = GetCountEvenNumbers(Array34);
ShowArray(Array34);
System.Console.WriteLine("В массиве {0} четных чисел", evenNum);
System.Console.WriteLine();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] Array36 = CreateRandomArray(25, 0, 999);
ShowArray(Array36);
int sumOddNum = GetSumOddNumbers(Array36);
System.Console.WriteLine("Сумма чисел нечётных позиций в массиве: {0}", sumOddNum);
System.Console.WriteLine();

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] Array38 = CreateRandomArray(25, 0, 999);
ShowArray(Array38);
int diff = GetDifferenceBetweenMinMax(Array38);
System.Console.WriteLine("Разница между максимальным и минимальным элементов массива: {0}", diff);

int[] CreateRandomArray(int Size, int start, int end)
{
    int[] RandomArray = new int[Size];
    for (int i = 0; i < RandomArray.Length; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int GetCountEvenNumbers(int [] Array)
{
    int result = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            result++;
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

int GetSumOddNumbers(int [] Array)
{
    int result = 0;
    for (int i = 1; i < Array.Length; i = i + 2)
    {
        result += Array[i];
    }
    return result;
}

int GetDifferenceBetweenMinMax(int [] Array)
{
    MinMaxArrayValues(Array, out int MinValue, out int MaxValue);
    System.Console.WriteLine("Minimum = {0}\nMaximum = {1}", MinValue, MaxValue);
    return MaxValue - MinValue;
}

void MinMaxArrayValues(int [] Array, out int MinValue, out int MaxValue)
{
    MinValue = Array[0];
    MaxValue = Array[0];

    for (int i = 1; i < Array.Length; i++)
    {
        if (MinValue > Array[i])
        {
            MinValue = Array[i];
        }
        if (MaxValue < Array[i])
        {
            MaxValue = Array[i];
        }
    }
}
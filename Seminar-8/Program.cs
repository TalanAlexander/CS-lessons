// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


int[,] array57 = GetRandomIntArray();
PrintArray(array57);
//System.Console.WriteLine(CountValues(array57));

int [] uniqCount = new int[CountValues(array57)];



int [,] GetRandomIntArray()
{
    Random rnd = new Random();
    int column = rnd.Next(2, 5);
    int rows = rnd.Next(2, 5);
    int min = 0;
    int max = rnd.Next(10);

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

int CountValues (int [,] inArray)
{
    // int count = 0;
    // int temp = 0;
    return 0;
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
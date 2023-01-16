int[] CreateRandomArray(int Size, int start, int end)
{
    int[] RandomArray = new int[Size];
    for (int i = 0; i < RandomArray.Length; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


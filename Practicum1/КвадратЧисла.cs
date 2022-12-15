internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        //int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число: ");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Квадрат {a} = {a * a}");
    }
}


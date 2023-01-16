/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
System.Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine() ?? "");
System.Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine() ?? "");

System.Console.WriteLine("Число А={0} в степени В={1}, составляет: {2}", numberA, numberB, MatPow(numberA, numberB));
System.Console.WriteLine("Нажмите Enter...");
Console.ReadLine();

int MatPow (int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result = result*numA;
    }
    return result;
}


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
System.Console.WriteLine("Введите число А: ");
int numberC = int.Parse(Console.ReadLine() ?? ""); 

GetNumberSum(numberC);
System.Console.WriteLine("Нажмите Enter...");
Console.ReadLine();
Console.Clear();

void GetNumberSum (int numC)
{
    int res = 0;
    int varNum = Math.Abs(numC);
    while (varNum > 0)
    {
        res = res + varNum % 10;
        varNum = varNum / 10;
    }
    System.Console.WriteLine("Во введённом числе {0}, сумма цифр {1}", numC, res);
}

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("Введите число элементов массива: ");
int lenArray = int.Parse(Console.ReadLine() ?? "");
System.Console.WriteLine("Введите максимальное значение элемента: ");
int numberE = int.Parse(Console.ReadLine() ?? "");

int [] MyArray = new int [lenArray];

GetArray(lenArray, numberE, ref MyArray);
PrntArray(ref MyArray);

System.Console.WriteLine("Нажмите Enter...");
Console.ReadLine();
Console.Clear();

void GetArray(int lenArray, int maxNumber, ref int [] MyArray)
{
    Random rnd = new Random();
    for (int i = 0; i < MyArray.Length; i++)
    {
        MyArray [i] = rnd.Next(maxNumber);
    }
}

void PrntArray (ref int [] MyArray)
{
    System.Console.WriteLine($"[{String.Join(", ", MyArray)}]");
}



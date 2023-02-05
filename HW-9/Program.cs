// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите N: ");
int numN = int.Parse(Console.ReadLine()??"1");

IntervalN(numN, 1);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите M: ");
int numerM = int.Parse(Console.ReadLine()??"0");
System.Console.WriteLine("Введите N: ");
int numerN = int.Parse(Console.ReadLine()??"1");
System.Console.WriteLine("M = {0}; N = {1} -> {2}", numerM, numerN, SumMNinterval(numerM, numerN));

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введите M: ");
int numberN = int.Parse(Console.ReadLine()??"0");
System.Console.WriteLine("Введите N: ");
int numberM = int.Parse(Console.ReadLine()??"1");
System.Console.WriteLine("N = {0}; M = {1} -> {2}", numberN, numberM, AnkermanFunc(numberN, numberM));


void IntervalN(int numN, int end)
{
    System.Console.Write($"{numN} ");
    if (numN == end)
    {
        return;
    }
    IntervalN(numN - 1, end);
}

int SumMNinterval(int numerM, int NumerN)
{
    int sum = numerM;
    if (numerM == numerN)
    {
        return numerN;
    }
    sum = sum + SumMNinterval(numerM + 1, numerN);
    return sum;
}

int AnkermanFunc(int numberN, int numberM)
{
    if (numberN == 0)
    {
        return numberM + 1;
    }
    else if (numberM == 0)
    {
        return AnkermanFunc(numberN - 1, 1);
    }
    else
    {
        return AnkermanFunc(numberN - 1, AnkermanFunc(numberN, numberM - 1));
    }
}
/*
ЗАДАЧА 13
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

ПРИМЕР: 
645 -> 5
78 -> Третьей цифры нет

32679 -> 6
*/

Console.Clear();

Console.WriteLine("Введите число: ");
string numString = Console.ReadLine() ?? "";
int num = Convert.ToInt32(numString);

int numLen = numString.Length;

if (num <= 0)
{
    numLen--;
}

if (numLen < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    double result = Math.Truncate((num / Math.Pow(10, numLen - 3)) % 10);
    Console.WriteLine(Math.Abs(result));
}


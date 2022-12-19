// Задача 10: Напишите программу, 
//которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трёхзначное число: ");

string numberString = Console.ReadLine();

string result = numberString.Substring(1,1);

System.Console.WriteLine($"Вторая цифра = {result}");

System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                             // Очищаем экран

//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите трёхзначное число: ");

string number2String = Console.ReadLine();

if (number2String.Length <= 2) 
{
    System.Console.WriteLine("А ведь просили ввести 3-х значное, третьей цифры нет");
}
else
{
    System.Console.WriteLine($"Третья цифра = {number2String.Substring(2,1)}");
}

System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                             // Очищаем экран

// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите число: ");

int numberOfDay= int.Parse(Console.ReadLine());


if (numberOfDay == 6 || numberOfDay == 7)
{
    System.Console.WriteLine("Введённый номер дня - выходной");
} 
else if (numberOfDay <0 || numberOfDay == 0 || numberOfDay > 7)
{
    System.Console.WriteLine("Введено неверное число!");   
}
else
{
    System.Console.WriteLine("Введённый номер дня - будний день");
}


System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                             // Очищаем экран
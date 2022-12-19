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

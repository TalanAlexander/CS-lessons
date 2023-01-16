// HomeWork 3
// Задача 19

/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

System.Console.Write("Введите пятизначное число: ");
string i = System.Console.ReadLine() ?? "";
int num = Convert.ToInt32(i);

if (((num / 10000) == (num % 10)) && (((num / 1000) % 10) == ((num / 10) % 10)))
{
    Console.WriteLine("Число {0} - полиндром", num);
}
else
{
    Console.WriteLine("Число {0} - не полиндром", num);
}
System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                             // Очищаем экран

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.Clear();

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine($"Расстояние между двумя точками: {d:f2}");

System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                             // Очищаем экран

/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

Console.Write("Введите число: ");
int numVar = Convert.ToInt32(Console.ReadLine());

for (int j = 1; j <= numVar; j++)
{
    Console.Write(Math.Pow(j, 3) + " ");
}

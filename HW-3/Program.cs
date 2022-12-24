// HomeWork 3
// Задача 19

/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

for (int i = 10000; i <= 99999; i++)
{
    FindPolyNumbers(i);
}

static void FindPolyNumbers (int num)
{
    string anyNumber = Convert.ToString(num);
    if ((anyNumber.Substring(0, 1) == anyNumber.Substring(4, 1)) && (anyNumber.Substring(1, 1) == anyNumber.Substring(3, 1)))
    {
        Console.WriteLine("Число {0} - полиндром", num);
    }

}
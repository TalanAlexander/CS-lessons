/* Задача 2: Напишите программу, которая на вход принимает 
два числа и выдает, какое число большее, а какое меньшее.
*/ 

Console.Clear();

System.Console.Write("Введите первое число: ");

int NumberA = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите второе число: ");

int NumberB = Convert.ToInt32 (Console.ReadLine());

int max = 0;

if (NumberA > NumberB)
{
    max = NumberA;
}
else
{
    max = NumberB;
}

System.Console.WriteLine($"Максимальное из введённых = {max}");

System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                                     // Очищаем экран

/*Задача 4: Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.
*/
Console.Clear();

System.Console.Write("Введите первое число: ");

NumberA = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите второе число: ");

NumberB = Convert.ToInt32 (Console.ReadLine());

System.Console.Write("Введите третье число: ");

int NumberC = Convert.ToInt32 (Console.ReadLine());

max = 0;

if (NumberA > NumberB && NumberA > NumberC)
{
    max = NumberA;
}
else if (NumberB > NumberA && NumberB > NumberC)
{
    max = NumberB;
}
else
{
    max = NumberC;
}

System.Console.WriteLine($"Максимальное из введённых = {max}");

System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                             // Очищаем экран


/*Задача 6: Напишите программу, которая на вход принимает число
и выдает, является ли число четным (делится ли оно на два без остатка).
*/

Console.Clear();

System.Console.Write("Введите число: ");

NumberA = Convert.ToInt32 (Console.ReadLine());

if ((NumberA % 2) == 0)
{
    System.Console.WriteLine($"Введёное число {NumberA} - чётное");
}
else
{
    System.Console.WriteLine($"Введёное число {NumberA} - нечётное");
}

System.Console.WriteLine("Для продолжения нажмите Enter ...");  // Переходим к следующей задаче
Console.ReadLine();                                             // Очищаем экран

/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

Console.Clear();

System.Console.Write("Введите положительное число больше 1: ");

NumberA = Convert.ToInt32 (Console.ReadLine());

NumberB = 2;
System.Console.WriteLine($"Ряд чётных чисел от 1 до {NumberA}: ");
while (NumberB <= NumberA)
{
    System.Console.Write(NumberB + " ");
    NumberB +=2;
}

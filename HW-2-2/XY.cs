Console.Clear();

Console.WriteLine("Введите координату X: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine);
else if(X > 0 && Y > 0);
{
    Console.WriteLine("Точка с введёными Вами координатами находится в первой четверти");
}
else if(X < 0 && Y > 0);
{
    Console.WriteLine("Точка с введёными Вами координатами находится во второй четверти");
}
else if(X < 0 && Y < 0);
{
    Console.WriteLine("Точка с введёными Вами координатами находится в третьей четверти");
}
else if(X > 0 && Y < 0);
{
    Console.WriteLine("Точка с введёными Вами координатами находится в четвёртой четверти");
}
else
{
    Console.WriteLine("Точка с введёнными координатами не находится ни в одной из четвертей");
}



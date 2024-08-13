// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

System.Console.Write("Введите координату X: ");
int X = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(System.Console.ReadLine());

if (X > 0 && Y > 0)
{
    System.Console.WriteLine($"X = {X} Y = {Y} => I");
}
else if (X < 0 && Y > 0)
{
    System.Console.WriteLine($"X = {X} Y = {Y} => II");
}
else if (X < 0 && Y < 0)
{
    System.Console.WriteLine($"X = {X} Y = {Y} => III");
}
else if (X > 0 && Y < 0)
{
    System.Console.WriteLine($"X = {X} Y = {Y} => IV");
}
else
{
    System.Console.WriteLine("Точка находится на оси координат");
}

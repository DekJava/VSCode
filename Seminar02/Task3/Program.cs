// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму.
// Если первое число не кратно второму, то программа выводит остаток 
// от деления. Пример:

// 14 и 5 => Нет, 4
// 16 и 8 => да
// 4, 3 => нет, 1

System.Console.Write("Ведите первое число: ");
int number1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(System.Console.ReadLine());

if(number1 % number2 == 0)
{
    System.Console.WriteLine("Первое число кратно второму");
}
else
{
    int remains = number1 % number2;
    System.Console.WriteLine($"Остаток от деления двух чисел равен {remains}");
}

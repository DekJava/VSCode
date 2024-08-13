// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// Пример:
// 40 => 4
// 96 => 9
// 72 => 7

System.Console.Write("Введите любое число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 0;
int max = 0;

if(number > 9 && number < 100)
{
    num1 = number / 10;
    num2 = number % 10;
    if(num1 > num2)
    {
        System.Console.WriteLine($"{number} => {num1}");
    }
    else
    {
        System.Console.WriteLine($"{number} => {num2}");
    }
}
else
{
    System.Console.WriteLine("Число находится за рамками заданного диапазона");
}

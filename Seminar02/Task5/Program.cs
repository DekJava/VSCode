// Выполнить задание №4 только ищем третью цифру с начала 
// Пример:

// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 99)
{
    while(number > 999)
    {
        number/= 10;
    }
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}
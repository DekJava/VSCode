// Напишите программу, которая выводит третью с конца цифру
// заданного числа  или сообщает, что третьей цифры нет.
// Пример: 

// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if(number > 99)
{
    int result = number % 1000 / 100;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}
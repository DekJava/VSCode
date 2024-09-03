// Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует/Не присутствует.

int[] numbers = {1, 3, 4, 19, 3};

foreach(int number in numbers)
{
    System.Console.Write(number + " ");
}

System.Console.WriteLine();
Console.Write("Введите искомое число: ");

int numberToFind = Convert.ToInt32(Console.ReadLine());

bool numberIsFinded = false;

foreach(int number in numbers)
{
    if(number == numberToFind)
        numberIsFinded = true;
}

if(numberIsFinded)
{
    System.Console.WriteLine("Число в массиве присутствует!");
}
else
{
System.Console.WriteLine("Числа в массиве нет!");
}

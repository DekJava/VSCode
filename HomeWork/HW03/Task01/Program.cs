// Задайте массив на 10 целых чисел. Напишите программу
// которая определяет количество чётных чисел в массиве
// Пример int[] numbers = {3, 1, 6, 6, 3, 6, 2, 6} => 5

int[] numbers = {2, 6, 1, 7, 4, 7, 9, 34, 43, 32};

int sum = 0;

foreach(int number in numbers)
{
    if(number % 2 == 0)
    {
        sum += 1;
    }
}

foreach(int number in numbers)
{
    System.Console.Write(number + " ");
}
System.Console.WriteLine(" => " + sum);
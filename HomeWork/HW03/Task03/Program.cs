// Задайте массив из вещественных чисел с ненулевой дробной
// частью. Найдите разницу между максимальным и минимальным
// элементом массива.

double[] numbers = {2.86, 4.2, 5.9, 7.3, 9.1, 12.5, 35.28};

double maxNumber = numbers[0];
double minNumber = numbers[0];

foreach(double number in numbers)
{
    if(number > maxNumber)
    {
        maxNumber = number;
    }
    else if(number < minNumber)
    {
        minNumber = number;
    }
}

System.Console.WriteLine(maxNumber - minNumber);
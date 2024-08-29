// Задача 3
// Найти сумму парных чисел в массиве и вывести их в новый массив

int[] numbers = {1, -5, 6, 6, 3, 9, -7};

foreach(int number in numbers)
{
    Console.Write(number + "\t");
}

Console.WriteLine(" ");

int[] multPairs = new int[numbers.Length / 2]; // Выделяем место в оперативной памяти

for(int i = 0; i < multPairs.Length; i++)
{
    multPairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}

foreach(int pair in multPairs)
{
System.Console.Write(pair + "\t");
}
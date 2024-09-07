// Задача!

// Задайте массив из N случайных чисел (N вводится с клавиатуры)
// Найдите количество чисел, которые оканчиваются на 1 и делятся
// нацело на число 7
// ________________________________________________________________

// В этом блоке основной код

internal class Program
{
    private static void Main(string[] args)
    {
        void Main()
        {
            int sizeOfArray = ReadInt("Введите размер массива: ");
            int[] array = GenerateArray(sizeOfArray);
            PrintArray(array);
            
        }

        // Ниже идёт создание разных методов:

        void PrintArray(int[] arrayForPrint)                          // (4.) Метод для вывода массива на экран
        {
            for(int i = 0; i < arrayForPrint.Length; i++)
            {
                System.Console.Write(arrayForPrint[i] + " ");
            }
            System.Console.WriteLine();
        }


        int[] GenerateArray(int size)                                   // (3.) метод генерирует массив
        {
            int[] tempArray = new int[size];

            for(int i = 0; i < size; i++)
            {
                tempArray[i] = new Random().Next(0, 10);
            }
            return tempArray;
        }


        int ReadInt(string message)                                 // (2.) метод для ввода пользователем чисел с клавиатуры
        {
            System.Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        int Function(int firstValue, int secondValue, int thirdValue) // (1.) Этот метод выполняет некоторые вычесления
        {
            int result = firstValue + secondValue + thirdValue;
            return result;
        }


        Main();
    }
}
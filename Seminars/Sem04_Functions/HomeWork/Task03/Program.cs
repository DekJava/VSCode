// Задача 3: 

// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)

internal class Program
{
    private static void Main(string[] args)
    {
        void Main()
        {
            Random rnd = new Random();
            int[] rndArray = new int[10];

                System.Console.Write("Массив до: ");
            for(int i = 0; i < rndArray.Length; i++)
            {
                int array = rndArray[i] = rnd.Next(1, 20);
                System.Console.Write(array + " ");

            }

            for(int i = 0; i < rndArray.Length / 2; i++)
            {
                int temp = rndArray[i];
                rndArray[i] = rndArray[rndArray.Length - 1 - i];
                rndArray[rndArray.Length - 1 - i] = temp;
            }
            System.Console.WriteLine();
            System.Console.Write("После    : ");
            for(int i = 0; i < rndArray.Length; i++)
        {
            System.Console.Write(rndArray[i] + " ");
        }

        }

        Main();
        
    }
}
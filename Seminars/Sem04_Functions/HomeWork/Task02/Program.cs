// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

internal class Program
{
    private static void Main(string[] args)
    {
        void Main()
        {
           Random rnd = new Random();
           int[] randomArray = new int[10];
           int count = 0;

           for(int i = 0; i < randomArray.Length; i++)
           {
                int num = randomArray[i] = rnd.Next(100, 999);
                System.Console.Write(num + ", ");

                if(randomArray[i] % 2 == 0)
                {
                    count += 1;
                }
           }
                System.Console.WriteLine();
                System.Console.WriteLine("В массиве " + count + " чётных чисел");
            
        }

        Main();
    }

}


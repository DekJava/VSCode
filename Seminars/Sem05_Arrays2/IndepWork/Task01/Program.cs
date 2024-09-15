// Двумерные массивы. Лекция

internal class Program
{
    private static void Main(string[] args)
    {
        void Main()
        {
            int[,] matrix2 = CreateMatrix(4, 12);
            PrintMatrix(matrix2);
        }

    int[,] CreateMatrix(int row, int column)
    {
        int[,] matrix = new int[row, column];
        Random rnd = new Random();

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(1, 11);
            }
        }
        return matrix;
    }

    void PrintMatrix(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }

    Main();
    }

}
// int n = 10;
int[] array = { 2, 30, 15, 7, 3, 1, 6, 8, 0, 12 };
int i = 0;
while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
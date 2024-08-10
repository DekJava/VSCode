void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write(($"{e} "));
    }
}

int[] array = { 3, 4, 2, 5, 2, 9, 10 };
ZeroEvenElements(array);
PrintArray(array);
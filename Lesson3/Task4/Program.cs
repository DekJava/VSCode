// Создаем генерацию рандомных чисел и ввод с клавиатуры

Random rnd = new Random();

int size = 30;
int[] arr = new int[size];
int i = 0;
while (i < size)
{
    arr[i] = rnd.Next(1, 10);
    i++;
}

i = 0;
while(i < size)
{
    Console.Write($"{arr[i]} ");
    i++;
}
Console.WriteLine(" ");

// Введение чисел с клавиатуры

int sizeIn = 7;
int[] array = new int[sizeIn];
int j = 0;

while(j < sizeIn)
{
Console.WriteLine("Введите число массива: ");
string input = Console.ReadLine();
array[i] = Convert.ToInt32(input);
j++;
}


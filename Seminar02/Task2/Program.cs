// Напишите программу, которая принимает на вход трехзначное число 
// и возводит вторую цифру в степень, равную третьей цифре. Пример:

// 487 => 8^7 = 2 097 158
// 254 => 5^4 = 625


System.Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if(number > 99 && number < 1000)
{
    int middleDigit = number / 10 % 10 ; // получаем двузначное целое число  и затем остаток от него (вторую цифру)
    int rightDigit = number % 10; // получаем остаток от трёхзначного числа (третью цифру)
    int power = 1;

    for( ; rightDigit > 0; rightDigit--)
    {
        power *= middleDigit;
    }
    System.Console.WriteLine(power);
}
else
{
    System.Console.WriteLine("Число не трёхзначное!");
}


// Напишите программу, которая на вход принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.

System.Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if(number < 0)
{
 System.Console.WriteLine(number);
}
else
{
    while(number > 0)
    {
        int currentDigit = number % 10;
        number /= 10;
    
        if(number > 0)
        {
        System.Console.Write(currentDigit + ", ");
        }
        else
        {
        System.Console.Write(currentDigit);
        }
    }
}
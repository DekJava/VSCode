// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Console.WriteLine("Enter first number: ");
//int firstValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());

// if(firstValue == secondValue * secondValue){
//     Console.WriteLine($"Yep {firstValue} - это квадрат {secondValue}");
// }
// else{
//     Console.WriteLine($"Nope, {firstValue} не квадрат {secondValue}");
// }



// Console.Write("Enter positive number here: ");
// int number = Convert.ToInt32(Console.ReadLine());

// // int i = -number;
// // while(i <= number){
// //     Console.Write(i + " ");
// //     i++;
// // }
// for(int i = -number; i <=number; i++){
//     Console.Write(i + " ");
// }



Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 < 1000 && num1 > 99){
    // выводить формулу
}
else{
    Console.WriteLine("Неверное число!");
    Console.Write("Введите трехзначное число: ");  
    Convert.ToInt32(Console.ReadLine());
}
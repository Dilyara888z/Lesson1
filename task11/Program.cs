// Напишите программу, которая выводит случайное трехзначное число
//  и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000); 
int num1= number/100;
int num2 = number%10;
int result = num1 * 10 + num3;
Console.WriteLine($"Случайное трехзначное число =>{number}");
Console.WriteLine($"двузначное число из трехзначного числа => {result}{result2}");

// int number = new Random().Next(100,1000); 
// int result = number/100;
// int result2 = number%10;
// Console.WriteLine($"Случайное трехзначное число =>{number}");
// Console.WriteLine($"двузначное число из трехзначного числа => {result}{result2}");
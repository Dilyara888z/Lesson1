//  Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
//  Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number < 100 && number > -100)
{
    Console.Write($"у числа {number} нет третьей цифры");
}
while (number > 999 || number < -999)
{
    number /= 10;
}
if (number <= 999 && number >= -999)
{
    int num1 = number % 10;
    Console.WriteLine($"третье число числа {number} -> {num1}");
}

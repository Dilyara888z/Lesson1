// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = default;
int i = number;
while (i > 0 || i < 0)
{
    sum = sum + (i % 10);
    i = i / 10;
}
if (sum < 0)
{
    sum = -sum;
}
Console.WriteLine($"сумма цифр в числе {number} = {sum}");

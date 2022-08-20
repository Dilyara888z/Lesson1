// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.Write("Введите пятизначное число: "); // 24542
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number /10000; 
int num2 = number %10;
int num3 = (number - num1*10000)/1000;
int num4 = (number /10)%10;
if (num1 == num2 && num3 == num4)
{
    Console.Write($"число {number} является палиндромом");
}
else
{
    Console.Write("не является палиндромом");
}
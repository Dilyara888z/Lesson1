// Напишите программу, которая принимает на вход число и
//  выдает количество цифр в числе.
//  456->3
//  78->2
//  89126->5


Console.WriteLine("Введите целое  число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (number <=0)
{
    number= -number;
}
int input = number;
while (number > 0)
{
  number/=10;
  i++;  
}
Console.WriteLine($"введенное число {input} состоит из {i} цифр");


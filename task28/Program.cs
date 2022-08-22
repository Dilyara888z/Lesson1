// напишите программу, которая принимает на вход число N 
// и выдает произведение чисел  от 1 до N.
// 4->24
// 5->120

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumb = 1;
for (int i = 1; i <= number; i++)
{
      firstNumb = firstNumb * i;
}
Console.WriteLine($"Произведение чисел от 1 до {number} равен {firstNumb}");


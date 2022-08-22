// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = number;
if (a > 0)
{
    int degree = 2;
    while (degree <= a)
    {
        i = i * number;
        degree++;
    }
}
else Console.WriteLine("Введенa отрицательная степень");
Console.WriteLine($"число {number} в степени {a} = {i}");

// напишите программу, которая принимает на вход число (N), 
// и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1,4,9,16,25
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i}  | {i * i}");
    }
}
else Console.WriteLine("введено некорректное число");

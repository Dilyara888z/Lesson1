// НАПИШИТЕ ПРОГРАММУ, КОТОРЯ ПРИНИМАЕТ НА ВХОД ЧИСЛО (А) И ВЫДАЕТ СУММУ
//  ЧИСЕЛ ОТ 1 ДО А.
// 7->28
// 4->10
// 8->36

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = default; // то же самое, что int sum = 0
// for (int i = 1; i <= num; i++) // три обязательных счетчика: 
// //int i = 0- блок инициализации счетчика, i < length - блок 
// //условия выполнения счетчика, i++ - счетчик итерации (изменения)
// {
//     sum = sum + i; // sum += i
// }
// Console.WriteLine($"сумма чисел от 1 до {num} = {sum}");


// // решение с помощью метода

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
if (number > 0)
{
int result =  SumNumbers(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {result}");
}
else
{
    Console.WriteLine("Некорректный ввод, введите положительное число");
}
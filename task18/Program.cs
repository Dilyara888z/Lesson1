// напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти
// (х и у)

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

String GetQuarter(int quarter)
{
    if (quarter == 1) return "в первой четверти X > 0 и Y> 0";
    if (quarter == 2) return "во второй четверти X < 0 и Y> 0";
    if (quarter == 3) return " третьей четверти Х< 0 и Y< 0";
    if (quarter == 4) return "в четвертой четверти Х > 0 и Y< 0";
    return "Введены некорректные координаты";
}
string result = GetQuarter(quarter);
Console.WriteLine(result);

// Console.WriteLine("Введите номер четверти: ");
// int A = Convert.ToInt32(Console.ReadLine());
// if (A == 1) Console.WriteLine(" в первой четверти X > 0 и Y> 0");
// else if (A == 2) Console.WriteLine(" во второй четверти X < 0 и Y> 0");
// else if (A == 3) Console.WriteLine(" в третьей четверти Х< 0 и Y< 0");
// else if (A == 4) Console.WriteLine("в четвертой четверти Х > 0 и Y< 0");
// else Console.WriteLine("Введен некорректный номер четверти");

// Console.Write("X: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y> 0) Console.WriteLine("Первая четверть");
// else if (X < 0 && Y> 0) Console.WriteLine("Вторая четверть");
// else if (X < 0 && Y< 0) Console.WriteLine("Третья честверть");
// else if (X > 0 && Y< 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некорректные координаты");

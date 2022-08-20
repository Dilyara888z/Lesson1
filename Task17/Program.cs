// напишите программу, которая принимает на вход координаты точки 
// (Х и У), причем Х не равен нулю и у не равен нулю и
//  выдает номер четверти плоскости. в которой нахоится эта точка


Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y> 0) Console.WriteLine("Первая четверть");
// else if (X < 0 && Y> 0) Console.WriteLine("Вторая четверть");
// else if (X < 0 && Y< 0) Console.WriteLine("Третья честверть");
// else if (X > 0 && Y< 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некорректные координаты");

String GetQuarter (int xc, int yc)  //способ хорош, если несколько переменных нужно искать. тогда не надозаново все вводить
{
if (xc > 0 && yc > 0) return "Первая четверть";
if (xc < 0 && yc > 0) return "Вторая четверть";
 if (xc < 0 && yc < 0) return"Третья честверть";
 if (xc > 0 && yc < 0) return"Четвертая четверть";
return "Введены некорректные координаты";
}
string result = GetQuarter(X , Y);
// string result2 = GetQuarter(5 , 6);
// string result3 = GetQuarter(-5 , -6);
// string result4 = GetQuarter(0 , 1);
Console.WriteLine(result);
// Console.WriteLine(result2);
// Console.WriteLine(result3);
// Console.WriteLine(result4);


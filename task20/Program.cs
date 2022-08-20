// напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// А (3,6); В (2, 1) -> 5,09
// А (7,-5); В (1, -1) -> 7,21

Console.WriteLine("Введите координаты точки 1: ");
Console.Write("X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2: ");
Console.Write("X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1));
Console.WriteLine("Расстояние между точками равно:{0: #.##}", result);
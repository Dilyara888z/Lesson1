﻿//  Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки 1: ");
Console.Write("X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2: ");
Console.Write("X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1)+ (Z2-Z1)*(Z2-Z1));
Console.WriteLine("Расстояние между точками равно {0: #.##}", result);

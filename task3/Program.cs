// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 1) Console.WriteLine("понедельник");
if(a == 2) Console.WriteLine("вторник");
if(a == 3) Console.WriteLine("среда");
if(a == 4) Console.WriteLine("четверг");
if(a == 5) Console.WriteLine("пятница");
if(a == 6) Console.WriteLine("суббота");
if(a == 7) Console.WriteLine("пятница");
Console.WriteLine("Указан неверный диапозон чисел");
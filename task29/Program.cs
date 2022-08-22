// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


void MasRandom(int[] array)
{
    Random rnd = new Random();
    for (int i=0; i< array.Length; i++)
    { 
        array[i] = rnd.Next(0,1000);
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i =0; i < array.Length; i++)
    {
        if (i< array.Length -1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
     Console.Write("]");
}

Console.WriteLine("Вывод массива: ");
int[] mas = new int[8];
MasRandom(mas);
ShowArray(mas);
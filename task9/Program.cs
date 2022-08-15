// Напишите программу, которая выводит случайное число
//  из отрезка [10,99] и показывает наибольшую цифру числа

int number = new Random().Next(10,100); // 10, 99+1 тк последнее число не вхоит в  диапозон
Console.WriteLine($"Случайное число диапазона 10 -99 =>{number}");

int firstDigit = number / 10; // / это деление и выводит целое число
int secondDigit = number % 10; // % показвает остаток

// if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа=>{firstDigit}");
// else Console.WriteLine($"наибольшаяя цифра числа=>{secondDigit}");

//int result = firstDigit > secondDigit ? firstDigit : secondDigit; // это альтернативный способ написания if и else
//Console.WriteLine($"наибольшаяя цифра числа=>{result}");
// что бы добавить еще и сравнение равных чисел:

// string result = firstDigit == secondDigit ? "Цифры равны"
// : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
// Console.WriteLine($"наибольшаяя цифра числа=>{result}");

int MaxDigit(int num)
{
    int firstDigit = num /10;
    int secondDigit = num % 10;
    if(firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ?  firstDigit : secondDigit;
}

int result = MaxDigit(number);
String res = result == 0 ? "Цифры равны" : result.ToString();
Console.WriteLine($"наибольшаяя цифра числа=>{res}");
// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    int digit1 = num / 10;
    int result = digit1 % 10;
    return result;
}
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SecondDigit(number));

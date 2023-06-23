// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if (number < 0)
// {
// number = -number;
// }
int count = -number;
while (count <= number)
{
Console.Write($"{count} ");
count++; // == coutn = count + 1;
}
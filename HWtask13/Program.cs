// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int number)
{
    while (number > 999)
    {
    number /= 10;
    }
    return number % 10;  
}
bool InvalidNum(int number)
{
    if (number < 100)
    {
    Console.WriteLine("Tретьей цифры нет"); 
    return false;   
    }
    return true;
}
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (InvalidNum(number))
{
    Console.WriteLine(ThirdDigit(number));
}
// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ (int number)
{
    int sum = 0;
    string UserNum = number.ToString();

    for (int i = 0; i < UserNum.Length; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summ(number));
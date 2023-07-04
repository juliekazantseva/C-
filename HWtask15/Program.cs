// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int day)
{
    if (day <= 5)
    {
        return true;
    }
    return false;
}
Console.WriteLine($"Введите день недли: ");
int day = Convert.ToInt32(Console.ReadLine());
if (Weekend(day))
{
   Console.WriteLine($"Пашем, товарищи!"); 
}
else if (day <=7 && day >=6)
{
    Console.WriteLine($"Гоу отдыхать!");
}
else if (day > 7)
{
    Console.WriteLine($"Здрасьте! 7 дней в неделе!!!");
}
// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool Palindrome(string num)
{
    for (int i = 0; i < num.Length / 2; ++i)
        if (num[i] != num[num.Length - 1 - i]) 
        return false;
        return true;
}

Console.WriteLine("Enter your number: ");
string number = Console.ReadLine();
if (Palindrome(number))
{
    Console.WriteLine("Палиндром!");
}
else
{
   Console.WriteLine("Не палиндром!"); 
}


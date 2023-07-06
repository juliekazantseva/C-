// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArrayWithRandomNumber(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return array;
}

double MaxMinSubstraction(double[] array)
{
    double min = array [0];
    double max = array [0];
    double sub = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array [i]) max = array[i];
        if (min > array [i]) min = array[i];
    }
    return sub = max - min;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double [] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
System.Console.WriteLine($"Разница между min и max: {Math.Round(MaxMinSubstraction(array), 2)}");
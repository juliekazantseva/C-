// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] FillMatrixWithRandom(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble()*10, 0);
        }   
    }
    return array;
}


void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} \t");
}
System.Console.WriteLine();
}
}

double[,] matrix = FillMatrixWithRandom(3, 4);
PrintMatrix(matrix);

System.Console.WriteLine("Введите номер позиции в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 0 && num < matrix.GetLength(0) && num < matrix.GetLength(1))
{
    System.Console.WriteLine("Есть такой номерок позиуции в массивчике! Бинго!");
}
else
{
    System.Console.WriteLine("Такой позиции в массиве нет.");
}
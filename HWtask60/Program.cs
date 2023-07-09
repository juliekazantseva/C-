// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrixWithRandom3D(int[,,] matrix)
{
    Random rnd = new Random();
    int temp = 0;
    int[] n = new int[matrix.GetLength(0) + matrix.GetLength(1) + matrix.GetLength(2)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                for (int l = 0; l < n.Length; l++)
                {
                    temp = rnd.Next(9,100);
                    for (int t = 0; t < n.Length; t++)
                        {
                            if (n[t] == temp)
                            {
                                temp = rnd.Next(0, 10);
                                t = 0;
                            }
                        }
                    n[l] = temp;
                    matrix[i, j, m] = temp;
                }
            }
        }
    }
    System.Console.WriteLine(string.Join(";", n));
}


void PrintMatrix3D(int[,,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int m = 0; m < matrix.GetLength(2); m++)
    {
        System.Console.Write($"{matrix[i, j, m]} ({i}, {j}, {m}); \t");
    }
System.Console.WriteLine();
}
}
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во страниц: ");
int page = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[row, column, page];
FillMatrixWithRandom3D(matrix);
PrintMatrix3D(matrix);

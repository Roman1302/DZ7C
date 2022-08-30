/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] RandomRealNumbers(int m, int n)
{
    double[,] result = new double[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(-10, 10) * random.NextSingle();
    return result;
}
void PrintDoubleArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j].ToString("N1")}  ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк(m):  ");
int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число столбцов(n):   ");
int.TryParse(Console.ReadLine(), out var n);
double[,] array = RandomRealNumbers(m, n);
PrintDoubleArray(array);

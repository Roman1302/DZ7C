/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

double[,] CreateArrayWithRandomNumbers(int numberRows, int numberСolumns)
{
    double[,] result = new double[numberRows, numberСolumns];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    }
    return result;
}

void PrintArrayRandomNumbers(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void OutputAverageValue(double[,] arr)
{
    int i = 0;
    int j = 0;
    double result = 0;
    double res = 0;
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (j = 0; j < arr.GetLength(1); j++)
    {
        result = 0;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            result += arr[i, j];
        }
        res = Math.Round((result / arr.GetLength(0)), 1);
        Console.Write($" {res}");
        if (j + 1 < arr.GetLength(1))
            Console.Write($";");
        else
            Console.WriteLine($". ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число строк (m): ");
if (!int.TryParse(Console.ReadLine()!, out int m))
    Console.WriteLine("Что-то пошло не так");

Console.WriteLine("Введите число столбцов (n): ");
if (!int.TryParse(Console.ReadLine()!, out int n))
    Console.WriteLine("Что-то пошло не так");

Console.WriteLine();

double[,] findings = CreateArrayWithRandomNumbers(m, n);
PrintArrayRandomNumbers(findings);
OutputAverageValue(findings);


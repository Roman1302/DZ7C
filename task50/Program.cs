/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет */

int[,] CreateArrayWithRandomNumbers()
{
    int[,] result = new int[4, 4];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    }
    return result;
}

void PrintArrayRandomNumbers(int[,] array)
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

void OutputGivenNumber(int[,] number, int a, int b)
{
    if (a <= 4 && b <= 4)
    {
        Console.WriteLine(number[a - 1, b - 1]);
    }
    else Console.WriteLine("Такого числа в массиве нет");
}

int[,] specifiedArray = CreateArrayWithRandomNumbers();
PrintArrayRandomNumbers(specifiedArray);
Console.WriteLine();

Console.Write("Введите номер строки (m): ");
int.TryParse(Console.ReadLine()!, out int m);

Console.Write("Введите номер столбца (n): ");
int.TryParse(Console.ReadLine()!, out int n);
Console.WriteLine();

OutputGivenNumber(specifiedArray, m, n);
Console.WriteLine();

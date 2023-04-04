// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
FindColsAverage(matrix);




void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindColsAverage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0.0;
        double count = 0.0;
        double average = 0.0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {    
            sum = sum + matrix[i,j];
            count++;
        }
    
    average = sum / count;
    average = Math.Round(average, 2);
    Console.WriteLine($"Среднее арифметическое всех элементов в {i+1} столбце = {average}");
    }
}
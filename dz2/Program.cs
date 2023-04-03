// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите число строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
FillArray(matrix);
PrintArray(matrix);
FindNumPosition(matrix, num);



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

void FindNumPosition(int[,] matrix, int num)
{
    bool check = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (num == matrix[i, j])
            {
            Console.WriteLine($"Искомое число находится в {i+1} строке, {j+1} столбце");
            check = true;
            }
        }
    }
    if (check == false)
    Console.WriteLine("Искомое число не найдено");
}
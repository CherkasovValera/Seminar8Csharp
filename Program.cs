//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();
// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// int[,] FillArray(int numLine, int numColumns, int maxRand, int minRand)
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"\t{matrix[i, j],6}");
//         }
//         Console.WriteLine();
//     }
// }
// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");
// int minRand = Prompt("Введите нижнюю границу диапазона ");
// int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand);
// PrintArray(matrix);

//         for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int n = 0; n < matrix.GetLength(1) - 1; n++)
//             {
//                 if (matrix[i, n] < matrix[i, n + 1])
//                 {
//                     int change = matrix[i, n + 1];
//                     matrix[i, n + 1] = matrix[i, n];
//                     matrix[i, n] = change;
//                 }
//             }
//         }
//     }

//  System.Console.WriteLine($"Отсортированный массив");
//  PrintArray(matrix);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();
// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// int[,] FillArray(int numLine, int numColumns, int maxRand, int minRand)
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"\t{matrix[i, j],6}");
//         }
//         Console.WriteLine();
//     }
// }
// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");
// int minRand = Prompt("Введите нижнюю границу диапазона ");
// int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand);
// PrintArray(matrix);
// int stringsum = 0;
// int sumMin = numLine * numColumns * maxRand;
// int numstring = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int n = 0; n < matrix.GetLength(1); n++)
//         stringsum += matrix[i, n];
//     if (stringsum < sumMin)
//     {
//         sumMin = stringsum;
//         numstring = i + 1;
//     }
//     stringsum = 0;
// }

// System.Console.WriteLine($"Минимум в строке  {numstring} равен  {sumMin}");


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[,] FillArray(int numLine, int numColumns, int maxRand, int minRand)
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minRand, maxRand + 1);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}
int numLine1 = Prompt("Введите количество строк массива №1 ");
int numColumns1 = Prompt("Введите количество столбцов массива №1 ");
int maxRand1 = Prompt("Введите верхнюю границу диапазона №1 ");
int minRand1 = Prompt("Введите нижнюю границу диапазона №1 ");
int[,] matrix1 = FillArray(numLine1, numColumns1, maxRand1, minRand1);
PrintArray(matrix1);
int numLine2 = Prompt("Введите количество строк массива №2 ");
int numColumns2 = Prompt("Введите количество столбцов массива №2 ");
int maxRand2 = Prompt("Введите верхнюю границу диапазона №2 ");
int minRand2 = Prompt("Введите нижнюю границу диапазона №2 ");
int[,] matrix2 = FillArray(numLine2, numColumns2, maxRand2, minRand2);
PrintArray(matrix2);

int[,] SumMatrix(int newLine, int newColumns)
{
    int[,] matrix = new int[newLine, newColumns];
    for (int i = 0; i < numLine1; i++)
    {

        for (int j = 0; j < numColumns2; j++)
        {

            for (int k = 0; k < numLine2; k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}
Console.WriteLine($"Произведение двух матриц:");
int newLine = numLine1;
int newColumns = numColumns2;
int[,] matrix = SumMatrix(newLine, newColumns);
PrintMatrix(matrix);




// int stringsum = 0;
// int sumMin = numLine * numColumns * maxRand;
// int numstring = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int n = 0; n < matrix.GetLength(1); n++)
//         stringsum += matrix[i, n];
//     if (stringsum < sumMin)
//     {
//         sumMin = stringsum;
//         numstring = i + 1;
//     }
//     stringsum = 0;
// }

//System.Console.WriteLine($"Минимум в строке  {numstring} равен  {sumMin}");


// 

// FillMatrix(matrix);
// PrintArray(matrix);
// System.Console.WriteLine(GetSum(matrix));
//  int GetSum(int[,] matrix)
//  {

// Array.Sort(matrix); // сортировка элементов массива
// foreach (int i in matrix) Console.Write($"{matrix}", i);
// Console.WriteLine();

// int sum = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     sum += matrix[i, i];
// }
// return sum;
//}
// int max = a[0]; // поиск максимального элемента
// foreach (int x in a) if (x > max) max = x;
// Console.WriteLine("max = " + max);
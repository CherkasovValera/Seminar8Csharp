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
            matrix[i, j] = new Random().Next(minRand, maxRand);
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
int numLine = Prompt("Введите количество строк массива ");
int numColumns = Prompt("Введите количество столбцов массива ");
int maxRand = Prompt("Введите верхнюю границу диапазона ");
int minRand = Prompt("Введите нижнюю границу диапазона ");
int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand);
PrintArray(matrix);
int stringsum = 0;
int sumMin = numLine * numColumns * maxRand;
int numstring = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int n = 0; n < matrix.GetLength(1); n++)
        stringsum += matrix[i, n];
    if (stringsum < sumMin)
    {
        sumMin = stringsum;
        numstring = i + 1;
    }
    stringsum = 0;
}

System.Console.WriteLine($"Минимум в строке  {numstring} равен  {sumMin}");





// int[,] matrix = new int[3, 3];

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
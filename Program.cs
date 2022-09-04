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

    // Console.WriteLine($"Среднее арифметическое по столбцу:");
    // int summa = 0;
    // double sredarif = 0;
    // for (int i = 0; i < matrix.GetLength(1); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(0); j++)
    //     {
    //         summa += matrix[j, i];
    //     }
    //     sredarif = (double)summa / matrix.GetLength(0);
    //     Console.Write($"\t  {sredarif:f2}");
    //     summa = 0;
    // }
//void OrderArrayLines(int[,] matrix)  // метод сортировки
//{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
//}
//int [,] newmassiv = OrderArrayLines(matrix);
 System.Console.WriteLine();
 PrintArray(matrix);








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
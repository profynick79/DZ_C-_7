// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int cols = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[rows, cols];
// double[,] resultMatrix = GetMatrix(rows, cols, 1, 20); //3 стр, 4 стлбц, числа от 1 до 20

// FillMatrixNumbers(resultMatrix);
// Console.WriteLine("Результат: ");
// PrintMatrix(resultMatrix);

// void FillMatrixNumbers(double[,] matrix) // Метод для заполнения матрицы случайными вещественными числами
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// double[,] GetMatrix(int rows, int cols, int min, int max) 
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().NextDouble();
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("");
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца:");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [10,8];
// FillArray(numbers);
// PrintArray(numbers);

// if (rows > numbers.GetLength(0) || cols > numbers.GetLength(1))
// {
//     Console.WriteLine("Такого элемента НЕТ");
// }
// else
// {
//     Console.WriteLine($"Значение элемента {rows} строки и {cols} столбца равно {numbers[rows-1,cols-1]}");
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100);
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t");
//         }   
//         Console.WriteLine(""); 
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//double[,] matrix = new double[rows, cols];
//double[,] resultMatrix = GetMatrix(rows, cols, 1, 20); //3 стр, 4 стлбц, числа от 1 до 20

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [rows,cols];
FillArray(matrix);
PrintArray(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}
Console.WriteLine();

void FillArray(int[,] array) // генерим массив в диапазоне от 1 до 1000
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 1000);
            }   
        }
}

void PrintArray(int[,] array) // выводим массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }   
        Console.WriteLine(""); 
    }
}



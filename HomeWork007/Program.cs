/*
//Задача47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2Array(int rows, int colums)
{
    double [,] array = new double[rows, colums];

    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().NextDouble() + new Random().Next(-10,10);
    return array;
}
void Show2Array(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            double align = Math.Round(array[i,j],1);
            Console.Write(align + " ");
         }   
        Console.WriteLine(); 
    }
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of colums");
int n = Convert.ToInt32(Console.ReadLine());

double [,] myArray = CreateRandom2Array(m, n);
Show2Array(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
/*
int [,] CreateRandom2Array(int rows, int colums)
{
    int [,] array = new int[rows, colums];

    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(1,10);
    return array;
}
void Show2Array(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine(); 
    }
}

bool FindElements(int [,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == a && j == b)
            return true;
    }
    return false;
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of colums");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the row index");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the column index");
int column = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n);
Show2Array(myArray);
FindElements(myArray, row, column);
Console.WriteLine(FindElements(myArray, row, column));
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandom2Array(int rows, int colums)
{
    int [,] array = new int[rows, colums];

    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(1,10);
    return array;
}
void Show2Array(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine(); 
    }
}

void AvgColums(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0; // обнуляем переменную заходя в новый цикл
        for (int i = 0; i < array.GetLength(0); i++)
            avg += array[i,j];
    avg = avg / array.GetLength(0);
    double align = Math.Round(avg,1);

    Console.Write($"{align};" + " ");
    }
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of colums");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n);
Show2Array(myArray);
Console.WriteLine();
AvgColums(myArray);

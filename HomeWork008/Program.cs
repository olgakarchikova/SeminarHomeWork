// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
/*
int [,] CreateRandom2Array(int rows, int colums)
{
    int [,] array = new int[rows, colums];

    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(0,10);
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

void SortedDown(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {    
                if(array[i,k] < array[i,k+1])
                {
                    int temp = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = temp;                
                }
            }
        }
       
    }
     
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of colums");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n);
Show2Array(myArray);
SortedDown(myArray);
Console.WriteLine();
Show2Array(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
void MinSumRow(int [,] array)
{
    int minSum = 0, indexRow = 0; 
    for (int i = 0; i < array.GetLength(1); i++)
        minSum += array [0,i];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) 
            sum += array [i,j];
        Console.WriteLine($"Sum of the row {i+1} = {sum};" + " ");
        
        if (sum < minSum) 
        {
            minSum = sum;
            indexRow = i;
        }
    }
    Console.WriteLine($"The row with the minimum sum of elements is {indexRow + 1}");
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of colums");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n);
Show2Array(myArray);
MinSumRow (myArray);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void [,] CreateRandom(int[,] array)
{  
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShowMatrix1(int [,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
         for (int j = 0; j < matrix1.GetLength(1); j++)
            Console.Write(matrix1[i,j] + " ");
        Console.WriteLine();
    }
}

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}


Console.WriteLine("Enter the number of rows of the first matrix");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the first matrix");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of rows of the second matrix");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the second matrix");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] matrix1 = CreateRandomMatrix1(a, b);
int [,] matrix2 = CreateRandomMatrix2(c, d);

ShowMatrix1(matrix1);
Console.WriteLine();
ShowMatrix2(matrix2);

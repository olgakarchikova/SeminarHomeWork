// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
/*
int [,] CreateRandom2Array(int rows, int columns)
{
    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < columns; j++)
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
Console.WriteLine("Input a number of columns");
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
int [,] CreateRandom2Array(int rows, int columns)
{
    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < columns; j++)
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
Console.WriteLine("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n);
Show2Array(myArray);
MinSumRow (myArray);
*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
void CreateRandom2Array(int[,] array)
{  
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

int[,] MultiplyArray(int[,] firstArray, int[,] secondArray)
{
    int [,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(1) != secondArray.GetLength(0))
        Console.WriteLine("Сannot be multiplied");

    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int n = 0; n < firstArray.GetLength(1); n++)
            {
                resultArray[i, j] += firstArray[i, n] * secondArray[n, j];
            }
        }
    }
    return resultArray;
}

Console.WriteLine("Input a number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[rows, columns];
int[,] secondArray = new int[rows, columns];

CreateRandom2Array(firstArray);
Show2Array(firstArray);
Console.WriteLine();

CreateRandom2Array(secondArray);
Show2Array(secondArray);
Console.WriteLine();

Show2Array(MultiplyArray(firstArray,secondArray));
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Задача решена не до конца!! 

/*
int [,,] CreateRandom3Array(int page, int rows, int columns)
{
    int [,,] array = new int[page, rows, columns];

    for (int k = 0; k < array.GetLength(0); k ++)
        for (int i = 0; i < array.GetLength(1); i++)
            for (int j = 0; j < array.GetLength(2); j++)
                array[k,i,j] = new Random().Next(10,99);
    return array;
}

void Show3Array(int [,,] array)
{
    for (int k = 0; k < array.GetLength(0); k ++)
    {   
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(1); i++)
        {    
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(2); j++)
            {    
                Console.Write($"{array[k,i,j]} ({k},{i},{j})" + " "); 
            }    
            
        }            
    }    
}

Console.WriteLine("Input a first value");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of rows");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns");
int z = Convert.ToInt32(Console.ReadLine());

int [,,] myArray = CreateRandom3Array(x, y, z);
Show3Array(myArray);
*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Павел, честно, не разобралась, просто скопипастила с нета :(
/*    
int n = 4;
int[,] spiralMatrix = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

while (num <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = num;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
    num++;
}

void Show2Array (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Show2Array(spiralMatrix);
*/
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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

/*
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

void MinSumRow(int [,] array)
{
    //int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array [i,j];
        }  
        Console.Write(sumRow + " ");
        int minSumRow = array[0,i];
        if (sumRow < minSumRow) 
        {   
            minSumRow = sumRow;
        }
        Console.Write($"minimum sum {minSumRow} of elements in a row {i}");
    }

    Console.WriteLine();   
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of colums");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n);
Show2Array(myArray);
MinSumRow (myArray);

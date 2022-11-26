// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

int [,] CreateRandom2Array(int rows, int colums, int minValue, int maxValue)
{
    int [,] array = new int[rows, colums];

    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
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
Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n, min, max);
Show2Array(myArray);
SortedDown(myArray);
Console.WriteLine();
Show2Array(myArray);

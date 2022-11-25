// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int [] CreateRandomeArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i ++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumPozitive(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count ++;
    return count;
}

Console.WriteLine("Input a number of elemets: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomeArray(n, min, max);
ShowArray(myArray);
int result = SumPozitive(myArray);
Console.WriteLine($"The number of numbers > 0 is: {result}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Point(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double alignX = Math.Round(x,1);
    double y = k1 * x + b1;
    double alignY = Math.Round(y,1);
    Console.WriteLine($"Intersection coordinates at the point: X {alignX}, Y {alignY} ");   
}

Console.WriteLine("Input the coefficient values B1: ");
double B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coefficient values K1: ");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coefficient values B2: ");
double B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coefficient values K2: ");
double K2 = Convert.ToInt32(Console.ReadLine());
Point(B1, K1, B2, K2);
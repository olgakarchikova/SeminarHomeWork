// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomeArray(int size) 
{
    int[] array = new int[size];

    for(int i = 0; i < size; i ++)
        array[i] = new Random().Next(100, 1000-1);
    return array;
}
void ShowArray(int [] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenNum(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array [i] % 2 == 0)
        count ++;
    return count;
}

Console.WriteLine("Input a number of elemets: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomeArray(n);
ShowArray(myArray);
Console.WriteLine(EvenNum(myArray));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomeArray(int size) 
{
    int[] array = new int[size];

    for(int i = 0; i < size; i ++)
        array[i] = new Random().Next(0,100);
    return array;
}

void ShowArray(int [] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Sum(int [] array)
{
     int sum = 0;
     for(int i = 1; i < array.Length; i = i +2)
        sum += array[i];
    return sum;
 }

Console.WriteLine("Input a number of elemets: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomeArray(n);
ShowArray(myArray);
Console.WriteLine(Sum(myArray));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRandomeArray(double size, double minValue, double maxValue) 
{
    double[] array = new double [size];

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

double Difference(double [] array)
{
    if (array [i])
}
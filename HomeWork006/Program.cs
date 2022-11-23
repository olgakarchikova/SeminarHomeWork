// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


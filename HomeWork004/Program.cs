/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Degree(int a, int b)
{
    int result = 1;
    for (int index = 1; index <= b; index ++)
        result *= a;
      //  Console.WriteLine(Math.Pow(a, b)); // При использовании Math.pow никаких циклов for использовать не надо.
    Console.WriteLine(result);
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени в которую необходимо возвести число "+ a +": ");
int b = Convert.ToInt32(Console.ReadLine());
Degree(a,b);
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int n)
{   
    int res = 0;
    while (n > 0)
    {
       res += n % 10;
       n /= 10;
    }
    return res;
}
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Sum(num);
Console.WriteLine($"Sum of numbers numbers {num} = {result}" );
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
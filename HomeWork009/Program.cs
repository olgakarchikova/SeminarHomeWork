// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);
}
ShowNumbers(10);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int m, int n)
{                    
    if (m == n) return m;                       
    else if (m < n) return n + SumNumbers(m, n - 1); 
    else return n + SumNumbers(m, n + 1);          
}
Console.WriteLine("Input a first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));

}
Console.WriteLine("Input a first pozitive number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second pozitive number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));
*/
/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт какое число большее, а какое меньшее.

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if(a > b)
{
    Console.WriteLine($"max number is {a}");
}
else
{
    Console.WriteLine($"max number is {b}");
}
*/

/* Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(c > a)
    {
        Console.WriteLine($"max = {c} ");
    }
    else
    {
        Console.WriteLine($"max = {a} ");
    } 
}
else
{
    if(c > b)
    {
        Console.WriteLine($"max = {c} ");
    }
    else
    {
        Console.WriteLine($"max = {b} ");
    }
}    
*/

/* Задача 3. Напишите программу, которая на вход принимает число и выдает яв-ся ли число четным.

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/* Задача 4. Напишите программу, которая на входе принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int carrent = 1;

while(carrent <= N)
{
    if(carrent % 2 == 0)
    {
        Console.Write(carrent + " ");
    }    
    carrent ++;
}
*/

// Решение с помощью метода:
/* Задача 1.
 
 int MaxNum (int a, int b)
{
    int max = a;
    if(b > max) max = b;
    return max;           
}
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = MaxNum(num1, num2);
Console.WriteLine($"Max number is: {result} ");
*/

/* task 2.

int ThreeNumMax(int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int result = ThreeNumMax(num1, num2, num3);
Console.WriteLine($"Max number is: {result} ");
*/

/* task 3.
// 1 variant
bool Chetnoe(int num)
{
    if (num % 2 == 0)
    {
        //Console.WriteLine("Четное");
        return true;
    }
    else
    {
       // Console.WriteLine("НЕчетное");
        return false;
    }    
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
bool res = Chetnoe (a);
Console.WriteLine(res);
*/
/* 2 variant

void Chetnoe (int a)
{
    if(a % 2 == 0)
        Console.WriteLine ("Число четное");
    else
         Console.WriteLine ("Число нечетное");
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Chetnoe(num);
*/
/*
// task 3
void Chetnum (int num)
{
    int current = 1;
    while(current <= num)
    {
        if(current % 2 == 0)
        Console.WriteLine(current + " ");
    current ++;
    }
}

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
Chetnum(N);
*/
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

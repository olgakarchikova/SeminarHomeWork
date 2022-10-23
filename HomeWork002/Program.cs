/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int num)
{
    int secdigit = (num / 10) % 10;
    num = secdigit;
    return num;
}

int number = new Random().Next(100, 1000);
int result = CutNumber (number);
Console.WriteLine($"second digit of number {number} is {result}");
*/

/*
// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int arg)
{
    int num = arg;
    while(num > 1000)
    {
        num = arg / 10;
    }
    arg = num % 10;
    return arg;
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("There is no third digit");
}
else
{
    int result = ThirdDigit(number);
    Console.WriteLine(result); 
}
*/

/*
// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Date(int num)
{
    
    if(num > 0 && num < 6)
    {
        Console.WriteLine("It's working day");
    }
    else
    {
        Console.WriteLine("It's weekend");
    }
    return num;
}
Console.WriteLine("Input the number of the day of the week:");
int daynum = Convert.ToInt32(Console.ReadLine());
int result = Date(daynum); 
*/
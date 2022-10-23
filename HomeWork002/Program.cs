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

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


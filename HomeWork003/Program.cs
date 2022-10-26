// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrom(int num)
{
    int n = num;
    int r = 0;
    while (n != 0)
    {
        r = r * 10 + n % 10;
        n = n / 10;
    }
    if (num == r)
        return true;
    else 
        return false;
}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Palindrom(number);
Console.WriteLine($"{result}");

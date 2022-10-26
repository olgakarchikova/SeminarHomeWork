/*
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
*/

/*
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Coordinates (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double A = (x2 - x1);
    A = Math.Pow(A, 2);
    double B = (y2 - y1);
    B = Math.Pow(B, 2);
    double C = (z2 - z1);
    B = Math.Pow(A, 2);
    double length = A + B + C;
    length = Math.Sqrt(length); 
    return length;
}

Console.Write("Input coortinates x1: ");
double numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coortinates y1: ");
double numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coortinates z1: ");
double numZ1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coortinates x2: ");
double numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coortinates y2: ");
double numY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coortinates z2: ");
double numZ2 = Convert.ToInt32(Console.ReadLine());
double result = Coordinates (numX1, numY1, numZ1, numX2, numY2, numZ2);
Console.WriteLine($"The distance between the specified points: {result}");
*/

/*
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int n)
{
    int current = 1;
    while (current <= n)
    {
        Console.Write(current * current * current + " " );
        current ++;
    }
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
*/
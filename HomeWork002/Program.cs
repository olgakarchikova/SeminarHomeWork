int CutNumber(int num)
{
    int sot = (num / 10) % 10;
    num = sot;
    return num;
}

int number = new Random().Next(100, 1000);
int result = CutNumber (number);
Console.WriteLine($"second digit of number {number} is {result}");
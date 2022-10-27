//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int number)
{
    return ((number / 10) % 10);
}

void PrintSecondDigit(int number)
{
    Console.WriteLine(SecondDigit(number));
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
//SecondDigit(number);
PrintSecondDigit(number);
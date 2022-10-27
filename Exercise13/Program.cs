//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void PrintThirdDigit (int number)
{
    if (number > 999)
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine(number %= 10);
    }
    else if (number > 99 & number < 1000)
    {
        Console.WriteLine(number %= 10);
    }
    else
    {
        Console.WriteLine($"Число {number} не имеет третьей цифры.");
    }
}

int number = new Random().Next(1, 100);
Console.WriteLine(number);
PrintThirdDigit(number);
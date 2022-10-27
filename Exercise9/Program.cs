//Дополнительная Задача 9
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void MultiplicityOfNumber(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine($"Число {number} кратно одновременно 7 и 23.");
    }
    else
    {
        Console.WriteLine($"Число {number} НЕ кратно 7 и 23 одновременно.");
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
MultiplicityOfNumber(number);
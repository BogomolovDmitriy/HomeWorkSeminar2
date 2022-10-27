//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfTheWeek (int number)
{
    if (number > 5 && number < 8) Console.WriteLine("Выходной день!");
    else if (number > 0 && number < 6) Console.WriteLine("Рабочий день!");
    else Console.WriteLine("Введено некорректное значение.");
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
DayOfTheWeek(number);
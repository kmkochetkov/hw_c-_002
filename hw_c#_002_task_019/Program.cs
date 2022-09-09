using System;
//Программа, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

void SecondNumber()
{
    Console.Write("Введите трехзначное число: ");
    int number = Math.Abs(int.Parse(Console.ReadLine()));

    // Проверка, является ли число трёхзначным
    if (number < 100 || number > 999)
    {
        Console.WriteLine ("Введённое число не является трёхзначным! ");
    }

    // Вычленение и печать второй цифры
    else
    {
        int secondNumber = number % 100 / 10;
        Console.WriteLine($"Вторая цифра введённого числа: {secondNumber}");
    }
}
SecondNumber();
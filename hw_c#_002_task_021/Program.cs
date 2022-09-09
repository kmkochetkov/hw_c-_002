// программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

void ThirdNumber()
{
    Console.Write("Введите число: ");
    int number = Math.Abs(int.Parse(Console.ReadLine()));
    int n = 0;
    // Проверка, является ли число трёхзначным
    if (number < 100)
    {
        Console.WriteLine ("Введённое число не имеет третьей цифры! ");
    }

    // Вычленение и печать третьей цифры
    else
    {
    double tempNumber = number; 
        while (tempNumber > 999)
        {
            tempNumber = tempNumber / 10;
            n++;
        }
 // Положение третьей цифры ищем через нахождение порядка числа
 //   Console.WriteLine($"Порядок числа: {n+2}");
    tempNumber = Math.Truncate(number / Math.Pow(10,n));
    Console.WriteLine($"Третья цифра слева: {tempNumber%10}");
    }
}
ThirdNumber();
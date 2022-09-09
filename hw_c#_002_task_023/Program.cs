// программf, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

void HolodayCheker()
{
    Console.WriteLine("Введите номер дня недели для проверки: ");
    int day = int.Parse(Console.ReadLine());
    
    //Проверка введённого дня недели
    if (day <1 || day >7) Console.WriteLine("Ошибочно введён номер дня недели!");
    
    // Проверка на принадлежность к выходным
    else
    {
        if (day == 6 || day == 7) Console.WriteLine("Введённый день - выходной");
        else Console.WriteLine("Введённый день - будний");
    }
}

HolodayCheker();
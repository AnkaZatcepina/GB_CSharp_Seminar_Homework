// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void IfDayoff(int x)
{
    if (x == 6 | x == 7) Console.WriteLine($"День {x} - выходной");
    else if (x == 1 | x == 2 | x == 3 | x == 4 | x == 5) 
        Console.WriteLine($"День {x} - будний");
    else Console.WriteLine("Некорректно ввели данные"); 
}

//Ввод числа
Console.Write("Введите номер дня недели: ");
//Вывод, выходной ли этот день или нет
IfDayoff(int.Parse(Console.ReadLine()));

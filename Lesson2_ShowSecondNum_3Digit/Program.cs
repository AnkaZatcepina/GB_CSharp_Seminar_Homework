// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void ShowSecondNum(int x)
{
    int x2 = ( Math.Abs(x) /10 ) % 10;
    Console.WriteLine($"Вторая цифра: {x2}");
}

//Ввод числа
Console.Write("Введите трёхзначное число: ");
//Нахождение второй цифры
ShowSecondNum(int.Parse(Console.ReadLine()));
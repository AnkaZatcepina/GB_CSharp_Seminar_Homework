// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.
double CalcPow(double a, double b)
{
    //Любое число в нулевой степени = 1
    if ( b == 0 ) return 1;

    double result = a;

    //Считаем целую часть числа для положительной степени
    double bAbs = Math.Abs(b);
    int intPart = Convert.ToInt32(bAbs / 1);
    for (int i = 2; i <= intPart; i++)
    {
        result = result * a;
    }
    
    //Считаем дробную часть степени
    double rest = bAbs % 1;
    if (rest > 0) result = result * a * rest;

    //Подсчёт для случаев с отрицательной степенью
    if (b < 0) result = 1 / result;

    return result;
}

//Ввод чисел
Console.Write("Введите число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
double b = double.Parse(Console.ReadLine());

//Поиск степени
double pow = CalcPow(a, b);

//Выводим наш результат и для сравнения результат из стандартной библиотеки Math
Console.WriteLine($"{a} в степени {b} через цикл = {pow}");
Console.WriteLine($"{a} в степени {b} через Math.Pow = {Math.Pow(a,b)}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Поиск точки пересечения
double[] GetIntersectionPoint(int k1, int b1, int k2, int b2)
{
    var point = new double[2];
    //Вычисляем X по формуле
    point[0] = Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2);
    //Вычисляем Y по формуле
    point[1] = k1 * point[0] + b1;

    return point;
}

//Ввод параметров
Console.WriteLine("Введите коэффициенты для прямых y = k1 * x + b1 и y = k2 * x + b2");
Console.Write("Введите коэффициент k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b2: ");
int b2 = int.Parse(Console.ReadLine()!);

//Поиск точки пересечения
var point = GetIntersectionPoint(k1, b1, k2, b2);

//Вывод результата
Console.WriteLine($"Точка пересечения двух прямых: ({point[0]};{point[1]})");

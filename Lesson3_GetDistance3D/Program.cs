// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//Поиск расстояния между точками
double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    return Math.Round(distance,2);
}

//Ввод координат первой точки
Console.Write("Введите координату X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = int.Parse(Console.ReadLine());

//Ввод координат второй точки
Console.Write("Введите координату X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = int.Parse(Console.ReadLine());

//Поиск расстояния
double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: {distance}");

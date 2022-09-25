// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Создание двумерного массива
double[,] CreateArray(int rows, int columns, int startValue, int endValue)
{
    var array = new double[rows,columns];
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            array[i,j] = Math.Round((random.Next(startValue, endValue) + random.NextDouble()),2);
        }
    }
    return array;
}

//Вывод массива в строку
void ShowArray(double[,] array)
{
    Console.WriteLine("[");
    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        Console.Write("{ ");
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }
        Console.Write("}");
        Console.WriteLine("");
    }
    Console.WriteLine("]");
}

//Нахождение элемента массива
string GetArrayValue(double[,] array, int i, int j)
{
    if (i < 0 || i >= array.GetLength(0)
     || j < 0 || j >= array.GetLength(1))
        return "Такого числа в массиве нет";
    else
        return $"Число: {array[i,j].ToString()}";
}

//Создание массива
var array = CreateArray(rows: 4, columns: 6, startValue: -10, endValue: 10);
//Вывод массива
ShowArray(array);

//Ввод строки и столбца
Console.Write("Введите номер строки: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int j = int.Parse(Console.ReadLine()!);

//Нахождение элемента массива
string element = GetArrayValue(array,i,j);
Console.WriteLine(element);

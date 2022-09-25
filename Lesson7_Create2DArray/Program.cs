// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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

//Создание массива
var array = CreateArray(rows: 4, columns: 6, startValue: -10, endValue: 10);

//Вывод массива
ShowArray(array);



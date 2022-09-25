// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Создание двумерного массива
int[,] CreateArray(int rows, int columns, int startValue, int endValue)
{
    var array = new int[rows,columns];
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            array[i,j] = random.Next(startValue, endValue + 1);
        }
    }
    return array;
}

//Вывод массива
void ShowArray(int[,] array)
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

//Вычисление средних арифметических по столбцам
double[] CalcAverageInArayColumn(int[,] array)
{
    //Создание массива. Длина = количество столбоц исходного массива
    var average = new double[array.GetLength(1)]; 
    //Сумма по столбцам
    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            average[j] = average[j] + array[i,j];
        }
    }
    //Делим на количество строк
    for (int j = 0; j < average.Length; j++)
    {
        average[j] = average[j] / array.GetLength(0);
    }

    return average;
}

//Вывод среднего арифметического
void ShowAverage(double[] array)
{
    Console.WriteLine("Среднее арифметическое по столбцам:");
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
    Console.WriteLine("}");
}

//Создание массива
var array = CreateArray(rows: 3, columns: 4, startValue: -10, endValue: 10);

//Вывод массива
ShowArray(array);

//Вычисление средних арифметических по столбцам
var average = CalcAverageInArayColumn(array);
//Вывод Среднего арифметического
ShowAverage(average);

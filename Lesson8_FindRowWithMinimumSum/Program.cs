// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine("");
    }
}

//Нахождение строки с наименьшей суммой элементов.
int FindRowWithMinimumSum(int[,] array)
{
    int rowIndexMin = 0;
    int sum = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            sum = sum + array[i,j];
        }
        if (i == 0) minSum = sum;
        else 
        {
            if (minSum > sum)
            {
                minSum = sum;
                rowIndexMin = i;
            }
        }
    }
    return rowIndexMin;
}


//Создание массива
var array = CreateArray(rows: 3, columns: 4, startValue: 0, endValue: 9);
ShowArray(array);

//Нахождение строки с наименьшей суммой элементов
int rowWithMinimumSum = FindRowWithMinimumSum(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {rowWithMinimumSum}");


// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

//Сортировка элементов строк по убыванию
int[,] SortRowsInArray(int[,] array)
{
    var sortedArray = array;
    for (int i = 0; i < sortedArray.GetLength(0); i++) //Строки
    {
        for (int j = 0; j < sortedArray.GetLength(1); j++) //Столбцы
        {
            for (int k = j+1; k < sortedArray.GetLength(1); k++) //Неотсортированные значения
            {
                //Если значение k больше j, меняем местами
                //На позиции j окажется максимальный из оставшихся элемент
                if (sortedArray[i,j] < sortedArray[i,k])
                {
                    int tmp = sortedArray[i,j];
                    sortedArray[i,j] = sortedArray[i,k];
                    sortedArray[i,k] = tmp;
                }
            }
        }
    }
    return sortedArray;
}


//Создание массива
var array = CreateArray(rows: 3, columns: 4, startValue: -10, endValue: 10);
ShowArray(array);

//Сортировка элементов строк по убыванию
Console.WriteLine("Отсортированный массив:");
var sortedArray = SortRowsInArray(array);
ShowArray(sortedArray);

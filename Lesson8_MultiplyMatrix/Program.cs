// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

//Произведение двух матриц
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    var multiplyMatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < multiplyMatrix.GetLength(0); i++) //Строки произведения
    {
        for (int j = 0; j < multiplyMatrix.GetLength(1); j++) //Столбцы произведения
        {
            for (int j1 = 0; j1 < matrix1.GetLength(1); j1++) //Столбцы 1й матрицы = Строки 2й матрицы
            {
                multiplyMatrix[i,j] = multiplyMatrix[i,j] + matrix1[i,j1] * matrix2[j1,j];
            }
        }
    }    
    return multiplyMatrix;
}


//Создание 1й матрицы
var matrix1 = CreateArray(rows: 2, columns: 2, startValue: 0, endValue: 9);
Console.WriteLine("Матрица 1:");
ShowArray(matrix1);

//Создание 2й матрицы
var matrix2 = CreateArray(rows: 2, columns: 2, startValue: 0, endValue: 9);
Console.WriteLine("Матрица 2:");
ShowArray(matrix2);

//Произведение матриц
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    var multiplyMatrix = MultiplyMatrix(matrix1, matrix2);
    Console.WriteLine("Произведение матриц:");
    ShowArray(multiplyMatrix);
}
else Console.WriteLine("Число столбцов матрицы 1 должно совпадать с числом строк матрицы 2");

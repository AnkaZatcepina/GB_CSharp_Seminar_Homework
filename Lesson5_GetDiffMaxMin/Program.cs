//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//Создание массива со случайными числами
double[] CreateArray(int length, int startValue, int endValue)
{
    var array = new double[length];
    var random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(startValue, endValue) + random.NextDouble();
    }
    return array;
}

//Находим максимум
double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
//Находим минимум
double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

//Вывод массива в строку
string ShowArray(double[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) result = $"{result}{array[i]}";
        else result = $"{result}, {array[i]}";
    }
    result = $"{result}]";
    return result;
}

//Создание массива
var array = CreateArray(5,-10,10);

//Подсчёт разницы максимального и минимального
double diff = GetMax(array) - GetMin(array);

//Вывод результата
Console.WriteLine($"Массив = {ShowArray(array)}");
Console.WriteLine($"Разница максимального и минимального = {diff}");


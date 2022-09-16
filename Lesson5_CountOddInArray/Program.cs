// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//Создание массива со случайными положительными трёхзначными числами
int[] CreateArray(int length, int startValue, int endValue)
{
    var array = new int[length];
    var random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);
    }
    return array;
}

//Count Odd values in Array
int CountOdd(int[] array)
{
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0) countOdd++;
    }
    return countOdd;
}

//Вывод массива в строку
string ShowArray(int[] array)
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
var array = CreateArray(10, 100, 999);

//Подсчёт чётных чисел, вывод результата
var countOdd = CountOdd(array);
Console.WriteLine($"Массив = {ShowArray(array)}");
Console.WriteLine($"Чётных чисел - {countOdd}");

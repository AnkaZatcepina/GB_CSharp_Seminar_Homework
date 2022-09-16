//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//Создание массива со случайными числами
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

//Сумма элементов, стоящих на нечётных позициях
int CalcSumOnEvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
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
var array = CreateArray(5,-10,10);

//Подсчёт суммы элементов, стоящих на нечётных позициях
var countSumOnEvenIndex = CalcSumOnEvenIndex(array);

//Вывод результата
Console.WriteLine($"Массив = {ShowArray(array)}");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {countSumOnEvenIndex}");

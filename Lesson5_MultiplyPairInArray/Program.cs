// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

//Произведение пар чисел
int[] MultiplyPairInArray(int[] array)
{
    //Находим длину нового массива
    int newLength = array.Length / 2;
    if (array.Length % 2 > 0) newLength++;

    //Заполняем массив
    var newArray = new int[newLength];
    for (int i = 0; i < newArray.Length; i++)
    {
        //Для 
        if (i+1 > array.Length / 2)
            newArray[i] = array[i];
        else    
            newArray[i] = array[i] * array[array.Length - i - 1];
    }
    return newArray;
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
var array = CreateArray(7,-10,10);

//Произведение пар чисел
var arrayMultiply = MultiplyPairInArray(array);

//Вывод результата
Console.WriteLine($"Заданный массив = {ShowArray(array)}");
Console.WriteLine($"Массив произведений = {ShowArray(arrayMultiply)}");
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Ввод элементов массива с клавиатуры
double[] CreateArrayNumbers(int size)
{
    var array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i}: ");
        array[i] = double.Parse(Console.ReadLine());;
    }
    return array;
}

//Подсчёт положительных
int CountPositiveNumbersInArray(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


//Ввод массива
double[] array = CreateArrayNumbers(6);
//Подсчёт положительных
int countPositiveNumbers = CountPositiveNumbersInArray(array);
//Вывод результата
Console.WriteLine($"Количество положительных чисел: {countPositiveNumbers}");

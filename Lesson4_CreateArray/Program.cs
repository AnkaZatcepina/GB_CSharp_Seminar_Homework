// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

//Ввод элементов массива с клавиатуры
string[] CreateArray()
{
    int countElement = 0;
    string element = "";
    string[] array = new string[0];
    //Выход из цикла, если пользователь введёт слово STOP
    while (true)
    {
        Console.Write("Введите элемент массива или напишите STOP для окончания ввода: ");
        element = Console.ReadLine();
        if (element == "STOP") break;

        //Добавление нового элемента в конец массива
        countElement++;
        Array.Resize(ref array, countElement);
        array[countElement - 1] = element;
    } 
    return array;
}

//Вывод массива в строку
string ShowArray(string[] array)
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

//Ввод массива
string[] array = CreateArray();
//Вывод массива
Console.WriteLine($"Массив = {ShowArray(array)}");


// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void ShowIntegDescending(int number)
{
    Console.WriteLine(number);
    if (number > 1)
        ShowIntegDescending(number - 1);    
}

Console.Write("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 1) Console.WriteLine("Некорректный ввод");
else ShowIntegDescending(number);

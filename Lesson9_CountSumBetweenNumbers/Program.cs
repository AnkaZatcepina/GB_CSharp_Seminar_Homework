// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int CountSumBetweenNumbers(int m, int n)
{
    if (m == n)
        return n;
    return m + CountSumBetweenNumbers(m+1, n);  
}

//Ввод чисел
Console.Write("Введите первое целое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int n = int.Parse(Console.ReadLine()!);

//Проверка какое число больше, будем считать сумму от меньшего к большему
int sum = 0;
if (m <= n) 
    sum = CountSumBetweenNumbers(m, n);
else sum = CountSumBetweenNumbers(n, m);

Console.WriteLine($"Сумма чисел между ними: {sum}");

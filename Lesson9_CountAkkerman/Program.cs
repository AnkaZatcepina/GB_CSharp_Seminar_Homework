// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
int CountAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return CountAkkerman(m - 1, 1);
    else
        return CountAkkerman(m - 1, CountAkkerman(m, n - 1));    
     
}


//Ввод чисел
Console.Write("Введите целое число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите целое число N: ");
int n = int.Parse(Console.ReadLine()!);

//Вычисление функции Аккермана
var akkerman = CountAkkerman(m, n);

Console.WriteLine($"Функция Аккермана A(M,N): {akkerman}");
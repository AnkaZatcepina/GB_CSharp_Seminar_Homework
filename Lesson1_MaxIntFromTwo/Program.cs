//Программа, которая на вход принимает два числа и выдаёт, какое число большее.

//Ввод двух чисел
Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());

//Нахождение большего числа
int result = 0;
if (number_1 > number_2) result = number_1;
else result = number_2;

//Вывод результата
Console.WriteLine($"Максимальное число: {result}");

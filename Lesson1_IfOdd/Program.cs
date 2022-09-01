//Программа, которая на вход принимает число и выдаёт, является ли число чётным

//Ввод числа
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

//Проверка чётности и вывод
if (number % 2 == 0) Console.WriteLine("Число чётное");
else Console.WriteLine("Число нечётное");
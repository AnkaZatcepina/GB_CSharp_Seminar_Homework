//Программа, которая на вход принимает число и выводит все чётные числа от 1 до этого числа

//Ввод числа
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

//Проверка, не меньше ли 2х
if (number < 2) Console.WriteLine("Чётных чисел нет");
else
{
//  Счётчик с шагом в 2, вывод чётных чисел   
    int odd_number = 2;
    while (odd_number <= number)
    {
        Console.WriteLine(odd_number);
        odd_number = odd_number + 2;
    }
}


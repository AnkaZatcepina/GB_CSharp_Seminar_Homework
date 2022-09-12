// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int CalcDigitSum(int x)
{
    int digitSum = 0;
    string xString = Math.Abs(x).ToString(); 
    char symbol = ' ';
    //Цикл по символам строки
    for (int i = 0; i < xString.Length; i++)
    {
        symbol = xString[i];
        digitSum = digitSum + Convert.ToInt32(symbol.ToString());
    }

    return digitSum;
}

//Ввод числа
Console.Write("Введите целое число: ");
int x = int.Parse(Console.ReadLine());

//Поиск суммы цифр
int digitSum = CalcDigitSum(x);

//Вывод результата
Console.WriteLine($"Сумма цифр = {digitSum}");

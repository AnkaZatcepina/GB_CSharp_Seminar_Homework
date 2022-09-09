// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Проверка числа, является ли оно палиндромом
bool CheckPalindrome(int numb)
{
    //Проверка на положительное пятизначное число
    if (numb < 10000 || numb >= 100000 ) return false;
    //Поиск цифр для сравнения
    int n1 = numb / 10000;
    int n2 = (numb / 1000) % 10;
    int n4 = (numb / 10) % 10;
    int n5 = numb % 10;
    //Сравниваем первую и последнюю цифру, вторую и предпоследнюю
    if (n1 == n5 & n2 == n4) return true;
    return false;
}

//Ввод числа
Console.Write("Введите пятизначное целое число: ");

//Проверка на палиндром
bool isPalindrome = CheckPalindrome(int.Parse(Console.ReadLine()));

//Вывод ответа
if (isPalindrome) Console.WriteLine("Ура! Это палиндром");
else Console.WriteLine("Это не палиндром");
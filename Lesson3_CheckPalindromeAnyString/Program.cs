// Программа, которая принимает на вход строку и проверяет, является ли оно палиндромом.

//Проверка строки, является ли она палиндромом
bool CheckPalindrome(string text)
{
    int length = text.Length;
    //Цикл слева и справа до середины слова
    for (int i = 0; i <= ( length / 2 ); i++)
    {
        char left = text[i];
        char right = text[length - i - 1];
        if (left != right) return false;
    }
    return true;
}

//Ввод строки
Console.Write("Введите строку: ");

//Проверка на палиндром
bool isPalindrome = CheckPalindrome(Console.ReadLine());

//Вывод ответа
if (isPalindrome) Console.WriteLine("Ура! Это палиндром");
else Console.WriteLine("Это не палиндром");

// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int[] GetCubeTable(int n)
{
    //Создаём пустой массив
    int[] cubeArray = new int[n];

    //Заполняем массив кубами
    for (int i = 1; i <= n; i++)
    {
        cubeArray[i-1] = i*i*i;
    }
    return cubeArray;
}

//Ввод числа
Console.Write("Введите положительное целое число: ");
int n = int.Parse(Console.ReadLine());

//Поиск таблицы кубов и вывод результата
if (n > 0)
{
    int[] cubeArray = GetCubeTable(n);
    Console.WriteLine("Таблица кубов:");
    for (int i = 0; i <= n-1; i++)
    {
        Console.WriteLine(cubeArray[i]);
    }
}
else Console.WriteLine("Нет кубов");

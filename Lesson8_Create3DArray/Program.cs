// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Провера числа на уникальность
bool IfExistsInArray(int value, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (value == array[i,j,k]) return true;
            }
        }
    }
    return false;
}

//Создание трёхмерного массива
int[,,] CreateArray(int x, int y, int z)
{
    var array = new int[x,y,z];
    int value = 0;
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) //x
    {
        for (int j = 0; j < array.GetLength(1); j++) //y
        {
            for (int k = 0; k < array.GetLength(2); k++) //z
            {
                value = random.Next(10, 100);
                while (IfExistsInArray(value, array))
                    value = random.Next(10, 100);
                array[i,j,k] = value;   
            }
        }
    }
    return array;
}

//Вывод массива
void ShowArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //x
    {
        for (int j = 0; j < array.GetLength(1); j++) //y
        {
            for (int k = 0; k < array.GetLength(2); k++) //z
            {
                Console.WriteLine($"{array[i,j,k]}({i},{j},{k})");
            }
        }
    }
}

//Создание массива
var array = CreateArray(2, 3, 4);

//Вывод массива
ShowArray(array);

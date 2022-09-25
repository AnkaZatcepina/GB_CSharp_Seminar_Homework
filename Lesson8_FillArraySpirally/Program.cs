//Напишите программу, которая заполнит спирально массив 4 на 4.
//Вывод массива
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //Строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //Столбцы
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine("");
    }
}

var array = new int[5,4];
int x = 0;
int y = 0;
int moveX = 0;
int moveY = 1;
int count = 0;
int turn = 0;
//Проверяем места движения. Если 2 раза попыталиь повернуть, значит идти больше некуда
while (turn < 2) 
{
    //Если мы не поворачивались перед этим, то заполняем элемент
    if (turn == 0)
    {
        count++;
        array[x,y] = count;
    }
    //Движение направо
    if (moveY == 1)
    {
        //Проверяем границу массива и не пустое ли значение справа
        if ( y + moveY < array.GetLength(1) ) 
        {
            if (array[x,y + moveY] == 0 ) 
            {
                y++;
                turn = 0;
            }
            else
            {
                moveY = 0;
                moveX = 1;
                turn++;
            }
        }
        else 
        {
            moveY = 0;
            moveX = 1;
            turn++;
        }
    }
    //Движение вниз
    if (moveX == 1)
    {
        //Проверяем границу массива и не пустое ли значение внизу
        if ( x + moveX < array.GetLength(0) ) 
        {
            if ( array[x + moveX,y] == 0 ) 
            {
                x++;
                turn = 0;
            }    
            else
            {
                moveX = 0;
                moveY = -1;
                turn++;
            }
        }    
        else
        {
            moveX = 0;
            moveY = -1;
            turn++;
        }
    }
    //Движение налево
    if (moveY == -1)
    {
        //Проверяем границу массива и не пустое ли значение справа
        if ( y + moveY >= 0 ) 
        {
            if ( array[x,y + moveY] == 0 ) 
            {
                y--;
                turn = 0;
            }
            else
            {
                moveY = 0;
                moveX = -1;
                turn++;
            }
        }    
        else
        {
            moveY = 0;
            moveX = -1;
            turn++;
        }
    }
    
    //Движение вверх
    if (moveX == -1)
    {
        //Проверяем границу массива и не пустое ли значение сверху
        if ( x + moveX >= 0 ) 
        {
            if ( array[x + moveX,y] == 0 ) 
            {
                x--;
                turn = 0;
            }
            else
            {
                moveX = 0;
                moveY = 1;
                turn++;
            }
        }    
        else
        {
            moveX = 0;
            moveY = 1;
            turn++;
        }
    }
}

ShowArray(array);

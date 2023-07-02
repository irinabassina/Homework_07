// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] Create2DArray(int randomRows, int randomColls) // создание двумерного массива
{
    int[,] createdRandom2dArray = new int[randomRows, randomColls];

    for (int i = 0; i < randomRows; i++)
    {
        for (int j = 0; j < randomColls; j++)
        {
            createdRandom2dArray[i, j] = new Random().Next(-100, 101);
        }
    }
    return createdRandom2dArray;
}

void Print2DArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + "  ");
        }
        Console.WriteLine(); // переход вывода на новую строку
    }
    Console.WriteLine(); // отступ от массива
}

int FindArrayElem(int [,] new2dArray, int userRow, int userColl)
{
    int result = 0;
    if (userRow < 1 || userColl < 1)
    {
        Console.Write("Позиции строк массива не могут быть отрицательными");
    }
    else if (userRow > new2dArray.GetLength(0) || userColl > new2dArray.GetLength(1))
    {
        Console.WriteLine("такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"{userRow}  {userColl} -> {new2dArray[userRow - 1, userColl - 1]}");
    }
    return result;
}

Console.Write("Введите позицию строки: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int userColl = Convert.ToInt32(Console.ReadLine());
int randomRows = new Random().Next(1, 10);
int randomColls = new Random().Next(1, 10);
int[,] new2dArray = Create2DArray(randomRows, randomColls);
Print2DArray(new2dArray);
FindArrayElem(new2dArray, userRow, userColl);
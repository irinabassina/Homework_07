// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void CountAverageCol(int[,] new2dArray)
{
    for (int j = 0; j < new2dArray.GetLength(1); j++)
    {
        double averageSum = 0;
        for (int i = 0; i < new2dArray.GetLength(0); i++)
        {
            averageSum = (averageSum + new2dArray[i, j]);
        }
        averageSum = Math.Round((averageSum / new2dArray.GetLength(0)), 1);
        Console.Write(averageSum + "; ");
        }
}

int randomRows = new Random().Next(1, 10);
int randomColls = new Random().Next(1, 10);
int[,] new2dArray = Create2DArray(randomRows, randomColls);
Print2DArray(new2dArray);
Console.Write("Среднее арифметическое каждого столбца: ");
CountAverageCol(new2dArray);
Console.Write($"\b\b.");
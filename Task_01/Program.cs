// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Create2DArray() // создание двумерного массива
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double[,] created2dArray = new double[userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2dArray[i, j] = Math.Round((new Random().Next(userMin, userMax) + new Random().NextDouble()), 1);
        }
    }
    return created2dArray;
}

void Print2DArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine(); // переход вывода на новую строку
    }
    Console.WriteLine(); // отступ от массива
}
double[,] new2dArray = Create2DArray();
Print2DArray(new2dArray);
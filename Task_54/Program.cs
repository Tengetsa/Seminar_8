// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Task54()
{
    Console.WriteLine("Введите количество строк массива: ");
    int lines = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = FillArray(lines, columns);
    PrintArray(array);
    Console.WriteLine();
    SortingRows(array);
    PrintArray(array);
}

int[,] FillArray(int lines, int columns)
{
    int[,] array = new int[lines, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 21);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SortingRows(int[,] array)
{
    int numberСell;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                if (array[i, j] > array[i, n])
                {
                    numberСell = array[i, j];
                    array[i, j] = array[i, n];
                    array[i, n] = numberСell;
                }
            }
        }
    }
}

Task54();

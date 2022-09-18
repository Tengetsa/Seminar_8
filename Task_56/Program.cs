// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Task56()
{
    Console.WriteLine("Введите количество строк массива: ");
    int lines = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = FillArray(lines, columns);
    
    PrintArray(array);
    Console.WriteLine();
    MinimumLineAmount(array);
}

int[,] FillArray(int lines, int columns)
{
    int[,] array = new int[lines, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
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

void MinimumLineAmount(int[,] array)
{
    int[] sumLine = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumLine[i] += array[i, j];
        }
    }

    int index = 0;

    for (int i = 1; i < sumLine.Length; i++)
    {
        if (sumLine[index] > sumLine[i])
        {
            
            sumLine[index] = sumLine[i];
            index = i;
        }
    }

    Console.WriteLine($"Строка с наименьшей суммой элементов  —  {index + 1}-ая ");
}

Task56();

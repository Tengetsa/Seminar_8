// Напишите программу, которая заполнит спирально массив 4 на 4.

void Task62()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[size, size];
    FillArraySpiral(array);
    PrintArray(array);
}

void FillArraySpiral(int[,] array)
{
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = number;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            --j;
        else
            --i;
        number += 1;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Task62();

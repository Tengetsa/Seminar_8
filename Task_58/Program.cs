// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Task58()
{
    Console.WriteLine("Введите количество строк первой матрицы: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов первой матрицы и строк второй матрицы: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов второй матрицы: ");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] firstMatrix = new int[firstNumber, secondNumber];
    int[,] secondMatrix = new int[secondNumber, thirdNumber];
    int[,] productsMatrix = new int[firstNumber, thirdNumber];

    Console.WriteLine("Первая матрица");
    FillArray(firstMatrix);
    PrintArray(firstMatrix);
    Console.WriteLine();

    Console.WriteLine("Вторая матрица");
    FillArray(secondMatrix);
    PrintArray(secondMatrix);
    Console.WriteLine();

    Console.WriteLine("Произведение двух матриц");
    ProductOfMatrices(firstMatrix, secondMatrix, productsMatrix);
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

void ProductOfMatrices(int[,] firstMatrix, int[,] secondMatrix, int[,] productsMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int n = 0; n < firstMatrix.GetLength(1); n++)
            {
                productsMatrix[i, j] += firstMatrix[i, n] * secondMatrix[n, j];
            }
            Console.Write($"{productsMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Task58();

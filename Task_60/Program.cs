// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Task62()
{
Console.WriteLine("Задайте размер куба но не больше 4(иначе двузначных чисел не хватит): ");
int size = Convert.ToInt32(Console.ReadLine());

int[,,] cube = new int[size, size, size];
FillArray(cube);
PrintArrayIndex(cube);
}

void FillArray(int[,,] array)
{
    int numbers;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                while (array[i, j, n] == 0)
                {
                    numbers = new Random().Next(10, 100);

                    if (NumbersWithoutRepetition(array, numbers) == false)
                    {
                        array[i, j, n] = numbers;
                    }
                }
            }
        }
    }
}

bool NumbersWithoutRepetition(int[,,] array, int numbers)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                if (array[i, j, n] == numbers) return true;
            }
        }
    }

    return false;
}

void PrintArrayIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i, j, n]}({i},{j},{n}) ");
            }
        }
        Console.WriteLine();
    }
}

Task62();

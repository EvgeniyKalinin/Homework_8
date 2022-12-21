void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void SumStringMatrix(int[,] matr)
{
    int minSum = 0;
    int minString = 0;
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        int sum = 0;
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            sum = matr[x, y] + sum;
            if (x == 0)
            {
                minSum = sum;
            }
        }
        if (sum < minSum)
        {
            minString = x;
            minSum = sum;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой чисел - {minString}");
}

Console.WriteLine("Введите число строк.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов.");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

FillArray(matrix);
Console.WriteLine();
Console.WriteLine($"Матрица {n} x {m}, заполненная случайными числами:");
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
SumStringMatrix(matrix);
Console.WriteLine();
PrintArray(matrix);
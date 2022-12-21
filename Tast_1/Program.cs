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
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}

void SortMatrix(int[,] matr)
{
    int indexMax1 = 0;
    int indexMax2 = 0;
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            int max = matr[x, y];
            int i = x;
            for (int j = y; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] >= max)
                {
                    indexMax1 = i;
                    indexMax2 = j;
                    max = matr[i, j];
                }

            }

            int save = matr[x, y];
            matr[x, y] = matr[indexMax1, indexMax2];
            matr[indexMax1, indexMax2] = save;
        }
    }
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
SortMatrix(matrix);
Console.WriteLine("Матрица после сортировки:");
Console.WriteLine();
PrintArray(matrix);
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

void MultiplyMatrix(int[,] matr, int[,] matr2, int[,] matr3)
{
    if (matr.GetLength(0) != matr2.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
        return;
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            matr3[i, j] = 0;
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                matr3[i, j] += matr[i, k] * matr2[k, j];
            }
        }
    }
    PrintArray(matr3);
}

Console.WriteLine("Введите число строк.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов.");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
int[,] matrix2 = new int[n, m];
int[,] matrix3 = new int[n, m];

FillArray(matrix);
FillArray(matrix2);

Console.WriteLine();
Console.WriteLine("Первая матрица:");
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
Console.WriteLine();
MultiplyMatrix(matrix, matrix2, matrix3);
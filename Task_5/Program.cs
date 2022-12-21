void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (matr[i, j] < 10)
            {
                Console.Write($"{matr[i, j]}  ");
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер матрицы.");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(matrix);
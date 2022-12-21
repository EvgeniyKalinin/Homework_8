void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Я не успел сделать заполнение случайными, уникальными числами(((
void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(0, 10);
            }
        }
    }
}

Console.WriteLine("Введите число строк.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число этажей (?).");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[n, m, l];


PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.Write("Введите количество строк матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];

void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,10);
        }
    }
}

void transMatrix(int[,] arg)
{
    if ( m != n )
    {
        Console.WriteLine("Матрица не квадратная!");
    }    
    else
    {
        int copy = 0;
        for (int i = 0; i < arg.GetLength(0); i++)
        {
            for (int j = i; j < arg.GetLength(1); j++)
            {
                copy = arg[i,j];
                arg[i,j] = arg[j,i];
                arg[j,i] = copy;
            }
        }
    }
}

FillMatrix(matrix);

PrintMatrix(matrix);

transMatrix(matrix);

Console.WriteLine();
PrintMatrix(matrix);

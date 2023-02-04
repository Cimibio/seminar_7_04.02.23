// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

void AvgMatrix(int[,] arg)
{
    int sum = 0;
    double result = 0;
    
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            sum = sum + arg[i,j];
        }
        Console.WriteLine("суммы столбцов: " + sum);
        result = sum / arg.GetLength(1);
        Console.WriteLine("average = " + result);
    }
    sum = 0;
}

FillMatrix(matrix);

PrintMatrix(matrix);

AvgMatrix(matrix);
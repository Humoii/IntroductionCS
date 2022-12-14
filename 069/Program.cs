// 69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

int[,] Random2DArray(int n, int m, int min = 0, int max = 30)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void Sort2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int k = 0; k < a.GetLength(1); k++) 
            for (int j = 0; j < a.GetLength(1) - 1; j++)
                if (a[i, j] > a[i, j+1])
                {
                    int t = a[i, j];
                    a[i, j] = a[i, j+1];
                    a[i, j+1] = t;
                } 
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)// GetLength(0) -передаеться количество строк
    {
        for (int j = 0; j < a.GetLength(1); j++)// GetLength(1) -передаеться количество столбцов
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

int[,] a = Random2DArray(3, 5);// (3,5) - "3" количество строк - "5" количество столбцов
Print2DArray(a);
System.Console.WriteLine();
Sort2DArray(a);
Print2DArray(a);
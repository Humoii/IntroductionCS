﻿// Создать подпрограмму Create2DArray(n,m),
// которая возвращает двумерный массив следующим правилом:
//  Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива



int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            a[i, j] = i+j;
    return a;
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

int[,] a= Create2DArray(4,5);
Print2DArray(a);
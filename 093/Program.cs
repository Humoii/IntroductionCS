// Задача 93: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void Multi2DArray(int[,] array1, int[,] array2)
{
    int n = 4;
    int m = 4;
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = array1[i, j] * array2[i, j];
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
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


int[,] array1 = new int[4, 4]{ { 1, 4, 7, 2 }, { 5, 9, 2, 3 },
                               { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

int[,] array2 = new int[4, 4]{ { 1, 5, 8, 5 }, { 4, 9, 4, 2 },
                               { 7, 2, 2, 6 }, { 2, 3, 4, 7 } };
Print2DArray(array1);
System.Console.WriteLine();
Print2DArray(array2);
System.Console.WriteLine();
Multi2DArray(array1, array2);

// Ввод-вывод двумерного массива, поиск в двумерном массиве,
// сортировка двумерного массива(по колонкам,
// так как в дз есть задание на сортировку по строкам).

int[,] Random2DArray(int n, int m, int min = 0, int max = 10)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 4; j++)
            a[i, j] = random.Next(min, max+1);
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
// int[,]a1=new int[3,4] {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
// int[,] a2 = {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
//             GetLength(0),GetLength(1)
int[,] a = Random2DArray(3, 5);// (3,5) - "3" количество строк - "5" количество столбцов
Print2DArray(a);

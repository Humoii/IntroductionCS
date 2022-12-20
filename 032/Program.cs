// 32. Найти сумму чисел от 1 до А


int SummaNum(int n)
{
    int k = 0;
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        k = k + 1;
        sum = sum + k;

    }
    return sum;
}

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SummaNum(a));

// Пузырьковая сортировка

int[] RandomIntArray(int N, int min, int max)
{
    int[] a = new int[N];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(0, 200);
    return a;
}
void PrintArray(int[] a, int tab = 5)
{
    string FormatSting = "{0," + tab + "}";
    for (int i = 0; i < a.Length; i++)
        System.Console.Write(FormatSting, a[i]);//"{0,"+tab+"}" -строчка фармотирования tab-табуляция
}

void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}

void BubbleSort(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        for (int j = 0; j < a.Length-1; j++)
            if (a[j] > a[j + 1])
                Swap(ref a[j], ref a[j + 1]);
}

int[] a = RandomIntArray(10, 0, 10);
PrintArray(a);
BubbleSort(a);
System.Console.WriteLine();
PrintArray(a);

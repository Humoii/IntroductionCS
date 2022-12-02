// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
/* 1 вариант
int length = 123;
// Random randomNumber = new Random();
int[] array = new int[length];
// int index = 0;
int d = 0; // счетчик
int n = 10;
int b = 99;
for (int index = 0;index < array.Length;index++)
{
    // array[index] = randomNumber.Next(1,99);
    array[index] =  1 + index;
    Console.Write($"{array[index],5}");
    if (index > n & index < b)
    {
        d++;
    }
}
 System.Console.WriteLine($" \n Количество элементов: {d}");// \n -переход на следующую строчку
*/
// 2 вариант
int[] RandomIntArray(int N, int min, int max)
{
    int[] a = new int[N];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(0, 200);
    return a;
}
void PrintArray(int[] a,int tab=5)
{
    string FormatSting="{0,"+tab+"}";
    for (int i = 0; i < a.Length; i++)
        System.Console.Write(FormatSting,a[i]);//"{0,"+tab+"}" -строчка фармотирования tab-табуляция
}
int Solve(int[] a)
{
    int count = 0;
    foreach (int el in a)
    {
        if (el >= 10 && el <= 99)
            count++;
    }
    return count;
}

int M = 123;
int[] a = RandomIntArray(M, 0, 200);
PrintArray(a,4);
System.Console.WriteLine($"\n{Solve(a)}");

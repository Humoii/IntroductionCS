// 47. Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int[] RandomIntArray(int size = 10, int min = 0, int max = 100)//size -размер
{
    int[] array = new int[size];
    Random random = new Random();
    for (int index = 0; index < size; index++)
        array[index] = random.Next(min, max+1);
    return array;
}

int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int index = 1; index < array.Length; index+=2)
      sum = sum + array[index];
    return sum;
}

void Print(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        System.Console.Write($"{array[index],5}");//,5 -это пять пробелов после запятой
}
int[] a = RandomIntArray(5, 0, 10);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(SumOddPositions(a));
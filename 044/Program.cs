// 44. Определить, присутствует ли в заданном массиве, некоторое число

int[] RandomIntArray(int size = 10, int min = 0, int max = 100)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int index = 0; index < size; index++)
        array[index] = random.Next(min, max);
    return array;
}

void Print(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        System.Console.Write($"{array[index],5}");//,5 -это пять пробелов после запятой
}

int LinearSearch(int[] array, int find, int startIndex = 0)
{
    int i = startIndex;
    while (i < array.Length && array[i] != find) i++;
    if (i == array.Length)
        return -1;
    else
        return i;
}
int[] m = RandomIntArray(5,1,6);
int find = 4;

Print(m);
System.Console.WriteLine();
int i = LinearSearch(m, find);

    if (i==-1)
        System.Console.WriteLine($"Element {find} not found");
    else
        System.Console.WriteLine($"Element {find} found at {i}");

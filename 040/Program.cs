// 40. Задать массив из 8 целых элементов и вывести их на экран.

int[] RandomIntArray(int size = 10)//size -размер
{
    int[] array = new int[size];
    Random random = new Random();
    for (int index = 0; index < size; index++)
        array[index] = random.Next(size);
    return array;
}

void Print(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        System.Console.Write($"{array[index],5}");//,5 -это пять пробелов после запятой
}

int[] a = RandomIntArray(8);
Print(a);

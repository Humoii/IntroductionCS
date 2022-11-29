// 34. Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] RandomIntArray(int size = 10, int min = 0, int max = 100)//size -размер
{
    int[] array = new int[size];
    Random random = new Random();
    for (int index = 0; index < size; index++)
        array[index] = random.Next(min, max);
    return array;
}

int SumPositive(int[] a)
{
    int s = 0;
    foreach (int el in a) // foreach -(для каждого) позволяет пройтись по всем элементам массива (int el in a) int el -(просто название)значит что какойто элемент из массива "а" от 0 до N
        if (el > 0) s = s + el;
    return s;
}
int SumNegative(int[] a)
{
    int s = 0;
    foreach (int el in a) 
        if (el < 0) s = s + el;
    return s;
}
void Print(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        System.Console.Write($"{array[index],5}");//,5 -это пять пробелов после запятой
}
int[] a = RandomIntArray(12, -9, 9);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных {SumPositive(a)}");
System.Console.WriteLine($"Сумма отрицательных {SumNegative(a)}");
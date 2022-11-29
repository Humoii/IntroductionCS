// 41. В Указанном массиве вещественных чисел найдите разницу между
//  максимальным и минимальным элементом

double[] RandomIntArray(int size = 10, double min = 0, double max = 100)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int index = 0; index < size; index++)
        array[index] = random.NextDouble();
    Console.Write(" {0:F2} ", random.NextDouble());
    return array;
}

double Max(double[] array)
{
    double max = array[0];
    for (int index = 1; index < array.Length; index++)
        if (array[index] > max) max = array[index];
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int index = 1; index < array.Length; index++)
        if (array[index] < min) min = array[index];
    return min;
}

void Print(double[] array)
{
    for (int index = 0; index < array.Length; index++)
        System.Console.Write($"{array[index],5}");
}
double[] a = RandomIntArray(2,0.0,0.2);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(Max(a) - Min(a));
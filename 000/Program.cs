// тренеровочная
// Создание вещественного массива
// double[] a = new double[3];
 
// Random random = new Random();
//     for (int j = 0; j < 3; j++)
//     {
//         a[j] = random.NextDouble();
//         Console.Write($"{a[j],4:F1}");
//     }
//     Console.WriteLine();
double[] RandomIntArray(int size = 0)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int index = 0; index < size; index++)
        array[index] = random.NextDouble();
    
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
        System.Console.Write($"{array[index],5:F2}");
}
double[] a = RandomIntArray(5);
Print(a);

System.Console.WriteLine();
System.Console.WriteLine(Max(a) - Min(a));
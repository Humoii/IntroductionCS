// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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
 System.Console.WriteLine($" \n Количество элементов: {d}");
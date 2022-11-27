// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int number = 123;
// Random randomNumber = new Random();
int[] array = new int[number];
int index = 0;
int d = 0; // счетчик
int n = 10;
int b = 99;
while (index < array.Length)
{
    // array[index] = randomNumber.Next(1,99);
    array[index] = array[index] + 1 + index;
    // Console.WriteLine(array[index]);
    if (index > n & index < b)
    {
        d++;
    }
     index++;
}
 Console.WriteLine(d);
// 36. Написать программу вычисления произведения чисел от 1 до N

int ProductOfNumbers(int n)
{
    int k = 0;
    int sum = 1;
    for (int i = 0; i < n; i++)
    {
        k = k + 1;
        sum = sum * k;

    }
    return sum;
}

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(ProductOfNumbers(a));

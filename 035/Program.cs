// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumOfDigits(int n)
{
    int k = 0;
    int sum = 0;
    for (int i = 0; i < n; i = i / 10)
    {
        k = n % 10;
        n = n / 10;
        sum = sum + k;
    }
    return sum;
}

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumOfDigits(a));


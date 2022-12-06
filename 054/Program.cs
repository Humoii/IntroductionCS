// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1
void Fibonacci(int n)
{
    int a = 1;
    int b = 0;
    int c = 0;
    Console.Write(0);
    for (int i = 0; i < n - 1; i++)
    {
        c = a + b;
        a = b;
        b = c;

        Console.Write($" {c}");
    }
}

int n = Convert.ToInt32(Console.ReadLine());
Fibonacci(n);

//через массив

int N = 10;
int[] a = new int[N];
a[0] = 0;
a[1] = 1;
for (int i = 2; i < n; i++)
    a[i] = a[i - 1] + a[i - 2];// рекурентная формула (следующее значение за счет использования предыдущих)
for (int i = 0; i < n; i++)
    System.Console.Write($"{a[i]}");
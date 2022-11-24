// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b) max = a;
if (b > c) max = b;
if (c > a) max = c;
System.Console.WriteLine($"Max={max}");

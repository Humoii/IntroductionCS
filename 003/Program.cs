// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

int a= Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    System.Console.WriteLine($"Max={a}");
}
else System.Console.WriteLine($"Max={b}");
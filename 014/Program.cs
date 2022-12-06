// 14. С клавиатуры вводятся два числа a и b.
//  Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double n = 0;
bool a1 = a % 2 == 0;
bool b1 = b % 2 == 0;
if (a1 && b1)
{
    System.Console.WriteLine("Multiple");
}
else
{
    n = a % b;
    System.Console.WriteLine(n);
}
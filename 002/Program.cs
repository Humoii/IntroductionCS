/* 2. С клавиатуры вводятся два вещественных числа. 
Проверять является ли одно из них квадратом второго
*/
/*
//полное условие
if ()
{
//true
}
else
{
//False
}
// неполное условие
if ()
{
//True
}
*/

System.Console.Write("Введите число a: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a * a == b)
{
    System.Console.WriteLine($"{b} являеться квадратом {a}");
}
if (b * b == a)
{
    System.Console.WriteLine($"{a} являеться квадратом {b}");
}
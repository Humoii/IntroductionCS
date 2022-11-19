// 1. С клавиатуры вводится целое число. Вывести квадрат числа.

int a;// 32 бит
a = 10;
System.Console.Write("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
int b = a*a;
System.Console.WriteLine(a+"^2 = "+b); // "a" склеиваеться спомощью "+" и пишеться строка "^2 = " склеиваем "+" с "b"
System.Console.WriteLine("{0}^2={1}",a,b);// до интрополяции строк {0}^2={1} -строчка форматирования
System.Console.WriteLine($"{a}^2={b}"); // $ -интрополяция строк
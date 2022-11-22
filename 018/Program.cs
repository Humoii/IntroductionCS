// 18. По двум заданным числам проверять является ли одно квадратом другого.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b) System.Console.WriteLine($"{b} являеться квадратом {a}");
    else
        if (b * b == a) System.Console.WriteLine($"{a} являеться квадратом {b}");
            else
                System.Console.WriteLine("Не являеться");
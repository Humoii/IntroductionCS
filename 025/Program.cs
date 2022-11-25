// 25. Вывести на экран кубы чисел от 1 до N
void CubesOfNumbers(int Number)

{
    int i = 1;
    int b = 0;
    while (i <= Number)
    {
        b = (int)Math.Pow(i, 3);
        i++;
        Console.WriteLine(b);
    }
    
}
System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
CubesOfNumbers(n);

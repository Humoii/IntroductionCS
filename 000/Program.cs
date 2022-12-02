// тренеровочная

int NumberSquares(int Number)
{

    for (int i=0;i < Number;i++)
    {
        Number = i * i;
        Console.WriteLine(Number);
    }
    return Number;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberSquares(N));
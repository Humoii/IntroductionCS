// 30. Вывести на экран таблицу квадратов чисел от 1 до N

int NumberSquaresTabl(int Number)
{
    
    for (int i=1;i <= Number;i++)
    {
        System.Console.WriteLine($"{i,4}{i*i,10}");
    }
    return Number;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
NumberSquaresTabl(N);

// int n=10;
// for(int i=0;i<n;i++)
// System.Console.WriteLine($"{i,4}{i*i,10}");
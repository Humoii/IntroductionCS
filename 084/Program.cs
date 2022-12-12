// 84. Определить являются ли введенные с клавиатуры символы правильной записью целого числа. 
// Вычислить сумму цифр введенного числа

int SumDigit(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + N % 10;
        N = N / 10;
    }
    return sum;
}

string s = Console.ReadLine()!;
bool a = s.All(char.IsDigit);
int d = 0;
if (a == true)
{
    d = Convert.ToInt32(s);
    System.Console.WriteLine(a);
    System.Console.WriteLine(SumDigit(d));
}
if (a == false)
{
    System.Console.WriteLine(a);
}


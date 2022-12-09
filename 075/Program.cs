// 75. Написать программу вычисления функции Аккермана

int ack(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    if (m == 0)
        return ack(n - 1, 1);
        else
        return ack(n - 1, ack(n, m - 1));
}
System.Console.WriteLine(ack(1, 2));

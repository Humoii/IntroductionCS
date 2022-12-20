// 89. Подсчитать сумму цифр, встречающихся в строке



string s = "1f234f5";

int SumDigits(string s)
{
    int sum = 0;
    for(int i = 0; i < s.Length; i++)
    {
        if ((s[i] > '0') && (s[i] < '9'))
        {
            sum = sum + (s[i] - '0');
        }
    }
    return sum;
}

System.Console.WriteLine(SumDigits(s));

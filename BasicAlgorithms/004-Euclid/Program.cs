// Алгоритм Эвклида
//обычный
int k =0;//счетчик
int GCD(int a,int b)
{
while(a!=b)
{
    k++;//счетчик
    if (a>b)
        a=a-b;
    else
        b=b-a;
}
        return a;
}


// быстрый
int QuickGCD(int a, int b)
{
    while (a != 0 && b != 0)
    {
        k++; //счетчик
        if (a > b)
            a = a % b;
        else
            b = b % a;

    }
    return a+b;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(QuickGCD(a, b));
System.Console.WriteLine(k);
k=0;
System.Console.WriteLine(GCD(a,b));
System.Console.WriteLine(k);
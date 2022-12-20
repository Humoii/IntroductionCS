// 26. Программа проверяет пятизначное число на палиндром.

int n = 12321;
int c = n;
int f = 0;
int sum = 0;
for (int i = 0; i < n; i=i/10)
{
    f = n % 10;
    n = n / 10;
    sum = sum*10+f;
}
System.Console.WriteLine(sum);
bool d1=sum==c;
System.Console.WriteLine(d1);



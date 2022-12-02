// 52. Написать программу преобразования десятичного числа в двоичное

string DecimalToBin(int n)
{
    string s="";
    if (n==0) return "0";
    while(n!=0)
{
    // System.Console.WriteLine(n%2);
    s=Convert.ToString(n%2)+s;
    n/=2;
}
return s;
}
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine(DecimalToBin(n));

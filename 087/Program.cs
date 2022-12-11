// 87. Удалить среднюю букву при нечетное длине строки 
// и две средние буквы при четной длине строки

 string s=Console.ReadLine()!;
 string s1;
int m=s.Length/2;
 if (s.Length%2==0)
 {
   s1=s.Remove(m-1,2);//Remove -позволяет удалить символ
 System.Console.WriteLine(s1);
 if(m==1)

    System.Console.WriteLine(s);
}
else
{
    s1=s.Remove(m,1);
System.Console.WriteLine(s1);
if(m==0)

    System.Console.WriteLine(s);
}

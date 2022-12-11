// String

string s="asdf";// string -это class, хронит ссылку где находиться строка
// immutable string (не изменяемые строки)
System.Console.WriteLine(s[0]);
for(int i=0;i<s.Length;i++)
    System.Console.WriteLine(s[i]);
// s[0]='S';
char[] cc=s.ToCharArray();
cc[0]='S';
s=new String(cc);

System.Text.StringBuilder sb=new System.Text.StringBuilder("asda"); // быстрее меняет строки
sb[0]='s';

s=sb.ToString();


// for(int i=0;i<100000;i++)
// s=s+"1";// создается новая строка! забивает память не эффективно
for(int i=0;i<100000;i++)
sb.Append("1");// новые строки не создает

string s1="Hello";// сравневаеться по содержимому
string s2="Hello";// сравневаеться по содержимому
System.Console.WriteLine(s1==s2);


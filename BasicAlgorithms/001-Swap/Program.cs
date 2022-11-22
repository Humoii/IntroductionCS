// Обмен значениями двух переменныч
/* Классический способ
int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
Console.WriteLine(b);
Console.WriteLine(a);
*/
/* Без использования третьей переменной
int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
Console.WriteLine(b);
Console.WriteLine(a);
*/
/* через "^" -ксор
 int a=5;
 int b=7;
 a=a^b;
 b=a^b;
 a=a^b;
System.Console.WriteLine($"a={a} b={b}");
*/
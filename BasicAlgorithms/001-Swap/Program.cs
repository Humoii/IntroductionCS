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
/* через метод(подпрограмму)
void Swap(ref int a, ref int b) //ref(reference)-ссылка если надо менять переменную в нутри(передача данных по ссылке) не создаеться копия a и b а переводит по ссылке где они лежат в памяти
{
    int t = a;
    a = b;
    b = t;
}
int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b); // подпрограмма обязательно вписуем ref если его используем
System.Console.WriteLine($"a={a} b={b}");
*/

//void Calculator(int a, int b, ref int sum, ref int multi) // ref используеться для множества значений, через int -можем вернуть только одно значение
void Calculator(int a, int b, out int sum, out int multi)//out -также используеться как ref только не обязательно передавать значения int sum,multi;
{
    sum=a+b;
    multi=a*b;
}
int a=3, b=5;
// int sum=0, multi=0;
// Calculator(a,b,ref sum,ref multi); //для ref обязательно передача значения int sum=0, multi=0;
int sum,multi;
Calculator(a,b,out sum,out multi); // для out не обязательна передача значения int sum,multi;
System.Console.WriteLine($"Сумма={sum} Умножение={multi}");
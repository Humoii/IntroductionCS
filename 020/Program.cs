// 20. Дано число. Проверить кратно ли оно 7 и 23
/* 1 Вариант
 int n=Convert.ToInt32(Console.ReadLine());
 if (n%7==0 && n%23==0)System.Console.WriteLine("Yes"); else System.Console.WriteLine("No");
*/
// 2 Вариант
int n=Convert.ToInt32(Console.ReadLine());
bool d1=n%7==0;
bool d2=n%23==0;
if (d1 && d2)System.Console.WriteLine("Yes"); else System.Console.WriteLine("No");
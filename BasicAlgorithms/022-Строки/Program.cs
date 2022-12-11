// Строки
/* Для ввода нескольких значений через строку 10 20 30

string[] s = Console.ReadLine();
string[] ss = s.Split(' ');
int[] n = new int[ss.Length];
for (int i = 0; i < ss.Length; i++)
{
    n[i] = Convert.ToInt32(ss[i]);
}
int a = n[0];
int b = n[1];
int c = n[2];
*/

string[] ss = Console.ReadLine()!.Split(' ');// ! -Добавлен оператор для прощения значений NULL в правую часть назначения.
int[] n = Array.ConvertAll<string,int>(ss,Convert.ToInt32);// обобщенные типы и параметризированные
int a = n[0];
int b = n[1];
int c = n[2];


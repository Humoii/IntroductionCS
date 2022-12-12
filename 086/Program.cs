// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.



string s = Console.ReadLine()!;

char find = 'a';
int count = 0;
foreach (var el in s)
{
    if (el == find)
        count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);

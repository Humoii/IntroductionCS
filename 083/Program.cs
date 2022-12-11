// 83. Подсчитать количество цифр среди вводимых с клавиатуры символов


string s = Console.ReadLine()!;// ! -Добавлен оператор для прощения значений NULL в правую часть назначения.
int k = 0;
// for (int i = 0; i < s.Length; i++)
// {
//     if(char.IsDigit(s[i])) k++;
// }
foreach (char c in s)
{
    if (char.IsDigit(c)) k++;// IsDigit -указывает находиться ли указаный символ как десятичная цифра
}
System.Console.WriteLine(k);
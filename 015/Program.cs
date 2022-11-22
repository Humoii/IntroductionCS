//  15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить,
//что её нет (Вывести: NO).

int n = Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n); // Abs -обсолютное значение
/* Вариант 1-простой
if (n<100) System.Console.WriteLine("No");
else System.Console.WriteLine(n/100%10);
*/

// Вариант 2 - 12345678 - третье число с начала

if (n > 999)
{
    while (n > 1000)
    {
        n = n / 10;
    }
    System.Console.WriteLine(n % 10);
}
else
{
    System.Console.WriteLine("NO");
}

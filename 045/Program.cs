// 45. Задать массив, 
// заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел.
int n = Convert.ToInt32(Console.ReadLine());
Random randomNumber = new Random();
int[] array = new int[n];
int l = 0;// счетчик не четных
int k = 0;// счетчик четных

for (int index = 0; index < n; index++)
{
    array[index] = randomNumber.Next(100, 1000);
    // System.Console.WriteLine(array[index]); //проверка заполнения массива
    if (array[index] % 2 == 0) k++;
    else l++;
}
System.Console.WriteLine($"Не четные = {l}");
System.Console.WriteLine($"Четные = {k}");

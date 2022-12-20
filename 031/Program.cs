// 31. Вывести на экран кубы чисел от 1 до N.
/* Вариант 1
void CubesOfNumbers(int Number)

{
    int i = 1;
    int b = 0;
    while (i <= Number)
    {
        b = (int)Math.Pow(i, 3);
        i++;
        Console.WriteLine(b);
    }
    
}
System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
CubesOfNumbers(n);
*/
// Вариант 2 

int[] CubesOfNumbers(int Number)

{
    int[] array = new int [Number];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = (int)Math.Pow(index + 1 , 3);
        Console.Write(array[index]+$", ");
        index++;
    }
    return array;
}
System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] N = CubesOfNumbers(n);
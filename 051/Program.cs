// 51. С клавиатуры вводится число N. Затем вводятся N чисел.
//  Определить сколько чисел больше 0 введено с клавиатуры



int[] ArrayReadLine (int Number)
{

int[] array = new int[Number];

for (int i=0;i<Number;i++)
{
Console.Write("Введите массив:");
array[i]= Convert.ToInt32(Console.ReadLine());
}
return array;

}

void Print(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        {
        System.Console.Write($"{array[index],5}");
        }
}

int AboveZero(int[] a,int find=0)
{
    int count = 0;
    foreach (int el in a)
    {
        if (el > find)
            count++;
    }
    return count;
}



Console.Write("Введите длину массива:");
int Number = Convert.ToInt32(Console.ReadLine());
int[] a = ArrayReadLine(Number);
Console.Write("Массив:");
Print(a);
System.Console.WriteLine($"\n Количество чисел больше нуля = {AboveZero(a)}");


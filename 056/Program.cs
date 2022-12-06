// 56. Написать программу копирования массива
// int[] ArrayRandom(int n)
// {
//   int[] array = new int [n];
//   Random random = new Random();
//   for (int i=0;i<array.Length;i++)
//   {
//   array[i]= random.Next(0,200);
//   }
//   return array;
// }
int[] CopyArray (int [] array)
{
  int[] copy = new int[array.Length];
for (int i=0;i<array.Length;i++)
{
  copy[i] = array[i];
}
return copy;
}
void Print(string n, int[] array)
{
  Console.Write(n);
    for (int index = 0; index < array.Length; index++)
        {
        System.Console.Write($"{array[index],5}");
        }
}
// int n = Convert.ToInt32(Console.ReadLine());
// int [] N = ArrayRandom(n);
// Copy(N);
 int[] array = { 5, 4, 7, 2, 9 };
Print($"Array:",array);
Console.WriteLine();
Print($"Copy array:",CopyArray(array));
Console.WriteLine();
int[] n = CopyArray(array);
n[1]=11;
Print($"Copy array:",n);

// Линейный поиск

int[] RandomIntArray(int size = 10, int min = 0, int max = 100)//size -размер
{
    int[] array = new int[size];
    Random random = new Random();
    for (int index = 0; index < size; index++)
        array[index] = random.Next(min, max);
    return array;
}
// подпрограмма вывода массива
void Print(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        System.Console.Write($"{array[index],5}");//,5 -это пять пробелов после запятой
}

/* Линейный поиск
int[] m = RandomIntArray();
int i = 0;
int find = 20;
m[4] = find;// вствляем элемент find в 4 индекс
Print(m);// выводим элементы массива
System.Console.WriteLine();
while (i < m.Length && m[i] != find) i++;
if (i == m.Length)
    System.Console.WriteLine($"Element {find} not found");
else
    System.Console.WriteLine($"Element {find} found at {i}");
*/

// Линейный поиск подпрограмма
int LinearSearch(int[] array, int find, int startIndex = 0)
{
    int i = startIndex;
    while (i < array.Length && array[i] != find) i++;
    if (i == array.Length)
        return -1;
    else
        return i;
}
int[] m = RandomIntArray();
int find = 20;

//  m[4]= find;// вствляем элемент find в 4 индекс
Print(m);// выводим элементы массива
System.Console.WriteLine();
int i = LinearSearch(m, find);
    if (i == -1)
        System.Console.WriteLine($"Element {find} not found");
    else
        System.Console.WriteLine($"Element {find} found at {i}");

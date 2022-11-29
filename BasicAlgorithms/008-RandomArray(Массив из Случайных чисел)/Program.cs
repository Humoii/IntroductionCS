// Массив из случайных чисел
/* Создание массива
int[] array;
array = new int[10];
*/
/* подпрограмма для создания массива заполненого рандомными числами от 0 до 100
int[] RandomIntArray(int size)//size -размер
{
    int[] array = new int[size];
    Random random=new Random();
    for (int index = 0; index<size; index++)
    array[index] = random.Next(0,100);
    return array;
}
// подпрограмма вывода массива
void Print(int[] array)
{
    for(int index = 0; index<array.Length; index++)
    System.Console.Write($"{array[index],5}");//,5 -это пять пробелов после запятой
}

int[] m=RandomIntArray(10);// 10 -количество элементов массива
Print(m);// выводим элементы массива
*/
// 3 вариант
void RandomIntArray(out int[] array, int size = 10, int min = 0, int max = 100)//size -размер
{
    array = new int[size];
    Random random = new Random();
    for (int index = 0; index < size; index++)
        array[index] = random.Next(min, max);
}
// подпрограмма вывода массива
void Print(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        System.Console.Write($"{array[index],5}");//,5 -это пять пробелов после запятой
}

int[] m;
RandomIntArray(out m, max: 110, size: 20);// здесь будет  max: 100, size: 10 из за,
//  того что превышает указанное в подпрограмме
Print(m);// выводим элементы массива

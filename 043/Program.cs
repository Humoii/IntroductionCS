// 43. Написать программу замены элементов массива на противоположные

int[] array = {1,-2,3,-4,5,0};

int index =0;
int b =0;
while (index < array.Length)
{
    b = -1 * array[index];

    index++;
    Console.WriteLine(b);
}


//Переварот массива

int[] RandomIntArray(int N, int min, int max)
{
    int[] a = new int[N];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(0, 200);
    return a;
}
void PrintArray(int[] a,int tab=5)
{
    string FormatSting="{0,"+tab+"}";
    for (int i = 0; i < a.Length; i++)
        System.Console.Write(FormatSting,a[i]);//"{0,"+tab+"}" -строчка фармотирования tab-табуляция
}

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Reverse(int[] a)
{
  for(int i=0; i<a.Length/2;i++) 
      Swap(ref a[i],ref a[a.Length-1-i]);//a.Length-1-i -последний элемент массива
}

int M = 10;
int[] a = RandomIntArray(M, 0, 200);
PrintArray(a,5);
Reverse(a);
// a=a.Reverse().ToArray();// имееться встроенная функция Reverse() для переварота, создает новый массив
System.Console.WriteLine();
PrintArray(a,5);
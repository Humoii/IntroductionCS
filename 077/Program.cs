// 77. Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.
//  Первые два элемента последовательности 0 и 1 

void Fibonachi(int N, int M = 0,int i = 1)
{
    
    if (N  > 0)
    {
        System.Console.Write($"{M,5}");
        Fibonachi(N - 1, i , M + i);
    }
}

Fibonachi(7);

// void Fibonachi(int N, int A =0,int B=1)
// {
//     if(N!=0)
// {
//     System.Console.Write($"{A,5}");
//       Fibonachi(N-1,B,A+B);
//     System.Console.Write($"{A,5}");
// }
// }
//  Fibonachi(10);
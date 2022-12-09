// 72. Показать натуральные числа от M до N, N и M заданы


void Loop(int M,int N)
{

    if(M<=N)
    {
        System.Console.Write($"{M,5}");
        Loop(M+1,N);
    }
    
}

Loop(5,10); 
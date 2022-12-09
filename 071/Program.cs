// 71. Показать натуральные числа от N до 1, N задано


void Loop(int N,int i = 1)
{

    if(i<=N)
    {
        System.Console.Write($"{N,5}");
        Loop(N-1);
    }
    
}

Loop(10); 


// 70. Показать натуральные числа от 1 до N, N задано


void Loop(int N,int i = 1)
{

    if(i<=N)
    {
        System.Console.Write($"{i,5}");
        Loop(N,i+1);
    }
    
}

Loop(10); 

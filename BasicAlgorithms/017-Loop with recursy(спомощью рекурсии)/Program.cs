// Вывести числа от 1 до N без использования цикла
// Цикл с помощью рекурсии
/*через goto -не рекамендуеться 
int i=1;
int N=10;
metka:
System.Console.WriteLine(i);
i++;
if (i<=N) goto metka;
*/
// рекурсия это где мы в подпрограмме обращаемся к ней самой,
//  таким образом возвращаясь и делая цикл
void Loop(int N,int i)
{

    if(i<=N)
    {
        System.Console.WriteLine(i);
        Loop(N,i+1);
    }
    
}

Loop(10,1); 
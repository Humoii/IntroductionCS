// 33. Возведите число А в натуральную степень B используя цикл

int NaturalDegree(int a, int b)
{
int j = 1;
for (int i = 0; i < b; i++)
{
    j = j*a;
}
return j;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NaturalDegree(a,b));
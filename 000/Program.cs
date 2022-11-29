// тренеровочная

double[] a = new double[5];
 
Random random = new Random();
    for (int j = 0; j < 5; j++)
    {
        a[j] = random.Next(100);
        Console.Write("{0,4}", a[j]);
    }
    Console.WriteLine();

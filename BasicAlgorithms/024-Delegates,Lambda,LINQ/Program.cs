// Delegates,Lambda,LINQ

//LINQ -Подсчитать сумму цифр, встречающихся в строке

// string s = "12345";
// int sum = s.ToCharArray().Cast<int>().Sum();
// System.Console.WriteLine(sum);


// Делегаты

// int CountDigits(string s)
// {
//     int count = 0;
//     foreach (var c in s)
//         if (char.IsDigit(c))
//             count++;
//     return count;
// }

// int CountLatin(string s)
// {
//     int count = 0;
//     foreach (var c in s)
//         if (c >= 'A' && c <= 'Z' || c > 'a' && c <= 'z')
//             count++;
//     return count;
// }

// int CountRusLetter(string s)
// {
//     int count=0;
//     foreach (var c in s)
//       if(c>='А' && c<='Я' || c>'а' && c<='я' || c=='Ё' || c=='ё')
//       count++;
//       return count;
// }

// int CountChars(string s, Delegate condition)//Delegate condition -передаем некою функцию
// {
//  int count=0;
//     foreach (var c in s)
//       if(condition)
//       count++;
//       return count;

using System.Linq;


// Func -делегат который принимает char выводит bool
delegate bool IsChar(char c);// сигнатура bool(char)

class Program
{

    static int CountChars(string s, Func<char,bool> isChar)//IsChar -это Delegate -передаем некою функцию
    {
        int count = 0;
        foreach (char c in s)
            if (isChar(c))
                count++;
        return count;

    }

    static bool IsLatin(char c)
    {
        return (c >= 'A' && c <= 'Z' || c > 'a' && c <= 'z');
    }

    static bool IsRus(char c)
    {
        return (c >= 'А' && c <= 'Я' || c > 'а' && c <= 'я' || c == 'Ё' || c == 'ё');
    }

    static void Main()
    {
        // string s = "Эта строка содержит latinskie буквы и цифры(12345)";

        //Linq
        string s="asd123";
        var queary=(from c in  s where (c >= 'A' && c <= 'Z' || c > 'a' && c <= 'z') select c).Count();
        var sum=(from c in s where char.IsDigit(c) select char.GetNumericValue(c)).Sum();// Linq -свояобразный язак в языке C#
        System.Console.WriteLine(sum);

/*
        System.Console.WriteLine(CountChars(s, IsLatin));
        System.Console.WriteLine(CountChars(s,
        delegate(char c)// анонимный делегат
        {
           return (c >= 'A' && c <= 'Z' || c > 'a' && c <= 'z'); 
        }
        ));
        
         System.Console.WriteLine(CountChars(s,
         ( c)=>// лямда -вырожения многострочное
        {
           return (c >= 'A' && c <= 'Z' || c > 'a' && c <= 'z'); 
        }
        ));

         System.Console.WriteLine(CountChars(s,
         ( c)=>c >= 'A' && c <= 'Z' || c > 'a' && c <= 'z' // лямда -вырожения однострочное
        ));

        System.Console.WriteLine(CountChars(s, IsRus));
        System.Console.WriteLine(CountChars(s,char.IsDigit));
        // => Лямбда вырожения
        */
    }


}

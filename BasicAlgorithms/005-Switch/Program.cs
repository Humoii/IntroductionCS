// С клавиатуры вводиться число - день недели. Определить день недели
/* Много строчный с else
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (a == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (a == 3)
{
    System.Console.WriteLine("Среда");
}
else if (a == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (a == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (a == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (a == 7)
{
    System.Console.WriteLine("Воскресение");
}
*/

// Много строчный через оператор switch можно использовать условия "<" ">"
System.Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)// оператор для кода где надо выбрать одно типо дня недели если через (if)
{
    case 1: //номер дня недели
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресение");
        break;
    default: //по умолчанию если не один case не подошол то выполниться он
        System.Console.WriteLine("Не правильный ввод");
        break;
}
/* GOTO
metka1:
goto metka1;// оператор безусловного перехода GOTO - нельзя использовать
*/
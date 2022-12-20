// 21. Дано число обозначающее день недели. Выяснить является номер дня недели выходным


string[] DaysOfTheWeek = {"NO", "Понедельник", "Вторник", "Среда", "Четверг",
                            "Пятница", "Суббота", "Воскресение"};
System.Console.Write("Введите день недели: ");
int index = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DaysOfTheWeek[index]);
if (index == 0)
{
    System.Console.WriteLine();
}
else
{
    if (index == 5 || index == 6)
    {
        System.Console.WriteLine("Выходной");
    }
    else
    {
        System.Console.WriteLine("Рабочий");
    }
}


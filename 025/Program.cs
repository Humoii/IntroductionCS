// 25. Задать номер четверти, показать диапазоны для возможных координат


int quarterNum = Convert.ToInt32(Console.ReadLine());
string range = "";

if (quarterNum == 1) range = "x > 0, y > 0";
else if (quarterNum == 2) range = "x < 0, y > ";
else if (quarterNum == 3) range = "x < 0, y < 0";
else if (quarterNum == 4) range = "x > 0, y < 0";
else System.Console.WriteLine("Такой четверти не существует");
if (quarterNum == 1 || quarterNum == 2 || quarterNum == 3 || quarterNum == 4)
System.Console.WriteLine($"Для {quarterNum}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");
System.Console.WriteLine();
// Char
// ASCii-кодировка
char c='a';// char -это структура, может хранить всебе один симвал
c='\x64'; // код символа х64 ричная система исчисления
c='\u0064'; // юни код
 char b='a';
 System.Console.WriteLine((int)b);// преобразования для того что бы посмотреть код символа
 System.Console.WriteLine(c.ToString()+b.ToString());//ToString -переводим в строку
if(b>='0'&& b<='9') System.Console.WriteLine("It's digit");
if(b>='A'&& b<='Z') System.Console.WriteLine("It's big Latin");
if(b>='a'&& b<='z'||b>='A'&& b<='Z') System.Console.WriteLine("It's digit");

if(Char.IsDigit(b)) System.Console.WriteLine("It's digit");

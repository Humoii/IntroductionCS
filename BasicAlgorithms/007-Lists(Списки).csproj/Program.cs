// Списки (списки работают дольше массивов)

List<int> temp;
temp=new List<int>();
for(int i=0;i<7;i++)
{
    temp.Add (Convert.ToInt32(Console.ReadLine()));
}
double sum=0;
for(int i=0; i<7; i++)
{
    sum=sum+temp[i];
}
System.Console.WriteLine(sum/temp.Count); // Count -счетчик элементов списка
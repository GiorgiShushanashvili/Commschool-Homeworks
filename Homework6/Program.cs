#region task1
Console.WriteLine("enter the size of array");
int numb = int.Parse(Console.ReadLine());

int[] newlist = new int[numb];
for (int i = 0; i < numb; i++)
{
    Console.WriteLine($"enter an element {i} ");
    newlist[i] = int.Parse(Console.ReadLine());
}
int[] evennumbers = Array.FindAll(newlist, x => x % 2 == 0);
int[] oddnumbers = Array.FindAll(newlist, x => x % 2 != 0);
foreach (var item in evennumbers)
{
    Console.WriteLine(item);
}
foreach (var item in oddnumbers)
{
    Console.WriteLine(item);
}


Console.ReadLine();



#endregion

#region task2


#endregion
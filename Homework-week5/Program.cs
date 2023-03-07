#region task1

Console.WriteLine("enter a number");
var num = Convert.ToInt32(Console.ReadLine());



if (num%5==0 )
{
    Console.WriteLine("number ends with 0 or 5");
}
else
{
    Console.WriteLine("number ends neither by 0 nor 5 ");
    
}
Console.ReadLine();

#endregion


#region task2

Console.WriteLine("Enter the first number");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first number");
var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1+num2);
Console.WriteLine(num1*num2);
if (num1>=num2 & num1!=0 & num2!=0)
{
    Console.WriteLine(num1 - num2);
    Console.WriteLine(num1 / num2);
} else if (num1 < num2 & num1 != 0 & num2 != 0)
{
    Console.WriteLine(num2 - num1);
    Console.WriteLine(num2 / num1);
} else if (num1==0 & num2 != 0)
{
    Console.WriteLine(num2-num1);
    Console.WriteLine("not allowed to devide by zero");
}
else if (num2 == 0 & num1 != 0)
{
    Console.WriteLine(num1 - num2);
    Console.WriteLine("not allowed to devide by zero");
}

#endregion 



#region task3
Console.WriteLine("swap numbers");
var x = Convert.ToInt32(Console.ReadLine());
var y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"x = {x}, y = {y}");
x = x * y;
y = x / y;
x = x / y;
Console.WriteLine($"x = {x}, y = {y}");
#endregion 

#region task4
Console.WriteLine("enter a number");
var a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=9; i++)
{
    Console.WriteLine(a * i);
}
#endregion

#region task5
Console.WriteLine("enter a number");
var b = Convert.ToInt32(Console.ReadLine());
int c = 1;
while (c < b)
{
    if( c % 2 == 0)
    {
        Console.WriteLine(Math.Pow(c, 2));
    }
    c++;
}


#endregion





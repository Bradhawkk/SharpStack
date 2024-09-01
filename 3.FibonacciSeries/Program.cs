#region 3.Fibonacci series
Console.WriteLine("Please enter the Number:");
int number = Convert.ToInt32(Console.ReadLine());

int x = 0;
int y = 1;
int z = 0;

Console.WriteLine("Fibonacci series:");

while (z < number)
{
    Console.WriteLine(z);
    z = x + y;
    x = y;
    y = z;
}

Console.ReadLine();
#endregion

Console.WriteLine("Enter the number to calculate the factorial");
int num = Convert.ToInt32(Console.ReadLine());
int result = Factorial(num);
Console.WriteLine($"The factorial of {num} is {result}");


static int Factorial(int num)
{
    if (num == 0)
    {
        return 1; // Base case: 0! is 1
    }
    else
    {
        return num * Factorial(num - 1); // Recursive case
    }
}
Console.WriteLine("Please enter the Palindrome Number:");
int palindromeNumber = Convert.ToInt32(Console.ReadLine());
int originalNumber = palindromeNumber;
int reversedNumber = 0;
int rem;

while (palindromeNumber > 0)
{
    rem = palindromeNumber % 10;
    reversedNumber = reversedNumber * 10 + rem;
    palindromeNumber = palindromeNumber / 10;
}

if (originalNumber == reversedNumber)
{
    Console.WriteLine("Palindrome hai bhaii");
}
else
{
    Console.WriteLine("Not a palindrome");
}
Console.ReadLine();
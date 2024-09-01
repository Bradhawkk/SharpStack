#region 1.Using Simple for loop
{
    Console.WriteLine("Please enter the String:");
    string userInput = Convert.ToString(Console.ReadLine());

    char[] charArray = userInput.ToCharArray();
    string result = string.Empty;
    for (int i = charArray.Length - 1; i >= 0; i--)
    {
        result += charArray[i];
    }
    Console.WriteLine($"O/p String:{result}");
}
#endregion

#region 2.Using Simple for loop without char array
{
    Console.WriteLine("Please enter the String:");
    string userInput = Convert.ToString(Console.ReadLine());

    char[] charArray = userInput.ToCharArray();
    string result = string.Empty;
    for (int i = charArray.Length - 1; i >= 0; i--)
    {
        result += charArray[i];
    }
    Console.WriteLine($"O/p String:{result}");
}
#endregion



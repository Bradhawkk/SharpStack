        Console.WriteLine("Choose an option for string reversal:");
        Console.WriteLine("1. Using Simple for loop with char array");
        Console.WriteLine("2. Using Simple for loop without char array");
        Console.WriteLine("3. Using 2 Pointer Technique");
        Console.Write("Enter your choice (1/2/3): ");

        string choice = Console.ReadLine();
        Console.WriteLine("Please enter the String:");
        string userInput = Console.ReadLine();

        switch (choice)
        {
            case "1":
                {
                    // Using Simple for loop with char array
                    char[] charArray = userInput.ToCharArray();
                    string result = string.Empty;
                    for (int i = charArray.Length - 1; i >= 0; i--)
                    {
                        result += charArray[i];
                    }
                    Console.WriteLine($"Reversed String: {result}");
                    break;
                }

            case "2":
                {
                    // Using Simple for loop without char array
                    string result = string.Empty;
                    for (int i = userInput.Length - 1; i >= 0; i--)
                    {
                        result += userInput[i];
                    }
                    Console.WriteLine($"Reversed String: {result}");
                    break;
                }

            case "3":
                {
                    // Using 2 Pointer Technique
                    char[] charArray = userInput.ToCharArray();
                    int left = 0;
                    int right = charArray.Length - 1;
                    while (left < right)
                    {
                        char temp = charArray[left];
                        charArray[left] = charArray[right];
                        charArray[right] = temp;

                        left++;
                        right--;
                    }
                    Console.WriteLine($"Reversed String: {new string(charArray)}");
                    break;
                }

            default:
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                break;
        }

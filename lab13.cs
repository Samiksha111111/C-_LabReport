using System;

class lab13
{
    static void Main()
    {
        Console.Write("Enter the number of strings: ");
        int numStrings = Convert.ToInt32(Console.ReadLine());

        string[] stringArray = new string[numStrings];

        for (int i = 0; i < numStrings; i++)
        {
            Console.Write("Enter string " + (i + 1) + ": ");
            stringArray[i] = Console.ReadLine();
        }

        string combinedString = string.Join(" ", stringArray);

        Console.WriteLine("Combined string: " + combinedString);
        Console.ReadLine();
    }
}

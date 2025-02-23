﻿using StringLibrary;

class Program
{
    static int row = 0;

    static void Main(string[] args)
    {
        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Begins with uppercase? {(input.StartsWithUpper() ? "Yes" : "No")}");
            Console.WriteLine();

            row += 4;
        } while (true);
    }

    // Method to reset console state
    static void ResetConsole()
    {
        if (row > 0)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        Console.Clear();
        Console.WriteLine($"\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");

        row = 3;
    }
}

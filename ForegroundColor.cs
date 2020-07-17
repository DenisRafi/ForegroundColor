using System;

class ByDenisRafi
{
    public static void Main()
    {
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        ConsoleColor currentBackground = Console.BackgroundColor;
        ConsoleColor currentForeground = Console.ForegroundColor;
        Console.WriteLine("All the foreground colors except {0}, the background color:",
        currentBackground);
        foreach (var color in colors)
        {
            if (color == currentBackground) continue;

            Console.ForegroundColor = color;
            Console.WriteLine("   The foreground color is {0}.", color);
        }
        Console.WriteLine();
        Console.ForegroundColor = currentForeground;
        Console.WriteLine("All the background colors except {0}, the foreground color:",
        currentForeground);
        foreach (var color in colors)
        {
            if (color == currentForeground) continue;

            Console.BackgroundColor = color;
            Console.WriteLine("   The background color is {0}.", color);
        }
        Console.ResetColor();
        Console.WriteLine("\nOriginal colors restored...");
    }
}

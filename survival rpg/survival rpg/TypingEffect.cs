using System;
using survival_rpg;

public class TypingEffect
{
    public static void PrintSlowly(string text, int millisecondsPerCharacter = 50)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Out.Write(text[i]);
            Thread.Sleep(millisecondsPerCharacter);
        }
        Console.WriteLine();
    }
}
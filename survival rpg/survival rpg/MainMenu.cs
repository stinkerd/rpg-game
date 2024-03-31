using System;
using survival_rpg; 

public class MainMenuTitle
{
    public string introText = "A small roguelike RPG created by Levi and Adil.";

    public void PrintIntroduction()
    {

        TypingEffect.PrintSlowly(CenterText(introText), 30); // Adjust speed (lower = faster)
        Thread.Sleep(1000);
        Console.WriteLine();

        
        Console.WriteLine(CenterText("========================"));
        Console.WriteLine(CenterText(" Crashed: Exo Escapists "));
        Console.WriteLine(CenterText("========================"));

        Console.WriteLine();
        Thread.Sleep(500);
    }

    private string CenterText(string text)
    {
        int screenWidth = Console.WindowWidth;
        int textLength = text.Length;
        int spacesBefore = (screenWidth - textLength) / 2;

        return new string(' ', spacesBefore) + text;
    }
}

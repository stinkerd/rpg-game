using System;

namespace survival_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij het Survival RPG spel!");

            bool running = true;
            Player player = new Player();

            while (running)
            {
                Console.WriteLine("\nHoofdmenu:");
                Console.WriteLine("1) Karakter aanpassen");
                Console.WriteLine("2) Klasse selecteren");
                Console.WriteLine("3) Credits");
                Console.WriteLine("4) Spel afsluiten");
                Console.WriteLine();

                Console.Write("Kies een optie: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("Hallo! Dit is waar je je karakter kunt aanpassen.");

                        // hier komt de logica en stukjes om je karakter aan te passen enz.

                        Console.WriteLine("Ben je tevreden met je keuze? (Ja/Nee)");
                        string satisfied = Console.ReadLine();

                        if (satisfied.ToLower() != "ja")
                        {
                            Console.Clear();
                            continue;
                        }

                        Console.WriteLine("Druk op backspace om terug te keren naar het hoofdmenu...");
                        while (Console.ReadKey().Key != ConsoleKey.Backspace) ;

                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();

                        Console.WriteLine("Kies je klasse:");
                        Console.WriteLine("1) Krijger");
                        Console.WriteLine("2) Handwerker");
                        Console.WriteLine("3) Dokter");
                        Console.WriteLine("4) Ontdekker");
                        Console.WriteLine();

                        Console.Write("Kies een klasse: ");
                        string classChoice = Console.ReadLine();

                        // hier komt de logica en stukjes om je klasse aan te passen enz.

                        switch (classChoice)
                        {
                            case "1":
                                Console.Clear();

                                player.Class = "Krijger";
                                break;
                            case "2":
                                Console.Clear();

                                player.Class = "Handwerker";
                                break;
                            case "3":
                                Console.Clear();

                                player.Class = "Dokter";
                                break;
                            case "4":
                                Console.Clear();

                                player.Class = "Ontdekker";
                                break;
                            default:
                                Console.Clear();

                                Console.WriteLine("Ongeldige keuze!");
                                break;
                        }

                        Console.WriteLine($"Je hebt de klasse '{player.Class}' gekozen.");
                        Console.WriteLine("Druk op backspace om terug te keren naar het hoofdmenu...");

                        while (Console.ReadKey().Key != ConsoleKey.Backspace) ;

                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();

                        Console.WriteLine("Credits:");

                        // hier komen wij enzo

                        Console.WriteLine("Druk op backspace om terug te keren naar het hoofdmenu...");
                        while (Console.ReadKey().Key != ConsoleKey.Backspace) ;

                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();

                        running = false;
                        break;

                    case "69":
                    case "420":
                        Console.Clear();
                        Console.WriteLine("grapjas");
                        break;

                    default:
                        Console.Clear();

                        Console.WriteLine("Ongeldige keuze!");
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("Bedankt voor het spelen!");
        }
    }
}

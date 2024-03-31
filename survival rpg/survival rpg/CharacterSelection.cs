using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace survival_rpg
{
    class CharacterSelection
    {

        public void ChooseCharacter()
        {

            Console.WriteLine("Choose your class:\n");
            Thread.Sleep(250);
            Console.WriteLine("1. Commando, Combat Specialist");
            Thread.Sleep(250);
            Console.WriteLine("2. Scavenger, Relic Hunter");
            Thread.Sleep(250);
            Console.WriteLine("3. Captain, Master Navigator\n");
            Thread.Sleep(250);
            Console.WriteLine("4. Back to menu\n");
            Console.WriteLine("------------------");

            string choice = Console.ReadLine();

            if (choice == "\u001B")
            {
                
            }


                switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You chose the Commando!");
                    Thread.Sleep(250);
                    Console.WriteLine("The Commando has high health for taking punishment and decent defense.");
                    Thread.Sleep(250);
                    Console.WriteLine("However, their inventory space is limited.");
                    Thread.Sleep(250);
                    ConfirmClassSelection("Commando", 120, 150, 15, 15);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You chose the Scavenger!");
                    Thread.Sleep(250);
                    Console.WriteLine("The Scavenger has a knack for finding loot with a large inventory space.");
                    Thread.Sleep(250);
                    Console.WriteLine("However, their lower health makes them fragile.");
                    Thread.Sleep(250);
                    ConfirmClassSelection("Scavenger", 100, 125, 25, 5);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("You chose the Captain!");
                    Thread.Sleep(250);
                    Console.WriteLine("The Captain has well-rounded stats and high fatigue for extended exploration.");
                    Thread.Sleep(250);
                    Console.WriteLine("However, their inventory space is limited.");
                    Thread.Sleep(250);
                    ConfirmClassSelection("Captain", 110, 200, 10, 20);
                    break;
                case "4":
                    Console.Clear();
                    new MainMenu().RunMenu();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(250);
                    ChooseCharacter(); // Restart character selection
                    break;
            }
        }

        public void ConfirmClassSelection(string name, int health, int fatigue, int inventorySpace, int defense)
        {
            Console.WriteLine();
            Console.WriteLine($"Are you sure you want to play as the {name}? (y/n)");
            Console.WriteLine("------------------");
            string confirm = Console.ReadLine().ToLower();

            if (confirm == "y")
            {
                // This is where you would typically start the actual game loop using the chosen character stats (health, fatigue, etc.)

                // Placeholder for the actual game loop
                Console.Clear();
                File.Create("..\\..\\..\\save.dat").Dispose();
                Console.WriteLine($"Great choice! Your adventure as the great {name} begins...");
                Thread.Sleep(2000);
                Console.WriteLine("\npress Enter to start your journey.");

                while (true)
                {
                    string userInput = Console.ReadLine();

                    if (string.IsNullOrEmpty(userInput))
                    {
                        Console.Clear();

                        if (name == "Commando")
                        {
                            new Commando().loreCharacter();
                        }
                        else if (name == "Scavenger")
                        {
                            new Scavenger().loreCharacter();
                        }
                        else if (name == "Captain")
                        {
                            new Captain().loreCharacter();
                        }

                        Thread.Sleep(3000);
                        Console.WriteLine("\npress Enter to continue..");

                        while (true)
                        {
                            string awaitingInput = Console.ReadLine();

                            if (string.IsNullOrEmpty(awaitingInput))
                            {
                                Console.Clear();
                                new PlayerMenu().ShowMenu();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\npress Enter to continue..");
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Great choice! Your adventure as the great {name} begins...");
                        Console.WriteLine("\npress Enter to start your journey.");
                    }
                }
            }
            else if (confirm == "n")
            {
                Console.Clear();
                Console.WriteLine("Alright, let's pick a different class.");
                ChooseCharacter(); // Restart character selection
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                Console.WriteLine("------------------");
                ConfirmClassSelection(name, health, fatigue, inventorySpace, defense);
            }
            
        }
        public void IntroText()
        {
            Console.WriteLine("");
        }
    }
}

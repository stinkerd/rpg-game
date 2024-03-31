using System;
namespace survival_rpg
{
    class MainMenu
    {
        internal string MenuText()
        {
            string centeredText = "";
            centeredText += CenterText("1. Start Game\n");
            centeredText += CenterText("2. Check Stats (Not Implemented Yet)\n");
            centeredText += CenterText("3. Exit Game\n");
            centeredText += CenterText("------------------");
            return centeredText;
        }

        public void RunMenu()
        {
            while (true)
            {
                Console.Clear();

                // Center title and menu text
                new MainMenuTitle().PrintIntroduction();
                Console.WriteLine(MenuText()); // Call the MenuText method and print its result
                Console.WriteLine();

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Start Game
                    Console.Clear();
                    new StartGame().RunStartGame();
                    break;
                }
                else if (choice == "2")
                {
                    // Stats (Not Implemented Yet)
                    Console.Clear();
                    new Stats().StatsInfo();
                }
                else if (choice == "3")
                {
                    // Exit Game
                    if (ConfirmExit())
                    {
                        Console.Clear();
                        Console.WriteLine(CenterText("Thank you for playing Crashed!"));
                        Environment.Exit(0);
                    }
                }
                else if (string.IsNullOrEmpty(choice))
                {
                    // Center error message
                    Console.WriteLine(CenterText("Invalid choice. Please try again."));
                }
                else
                {
                    // Center error message
                    Console.WriteLine(CenterText("Invalid choice. Please try again."));
                }
            }
        }

        private bool ConfirmExit()
        {
            Console.Clear();

            // Center exit confirmation
            Console.WriteLine(CenterText("Are you sure you want to exit? (y/n)"));
            Console.WriteLine(CenterText("------------------"));

            string confirm = Console.ReadLine().ToLower();

            if (confirm == "y")
            {
                return true;
            }
            else if (confirm == "n")
            {
                return false;
            }
            else
            {
                // Center error message
                Console.WriteLine(CenterText("Invalid input. Please enter 'y' or 'n'."));
                Console.WriteLine(CenterText("------------------"));

                return ConfirmExit(); // Recursive call for invalid input
            }
        }

        private string CenterText(string text)
        {
            int screenWidth = Console.WindowWidth;
            int textLength = text.Length;
            int spacesBefore = (screenWidth - textLength) / 2;

            return new string(' ', spacesBefore) + text;
        }
    }
}

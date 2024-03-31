using System;

namespace survival_rpg
{
    public class Stats
    {
        private const string StatsText = @"
Not implemented! (;
1. Go back to menu
        ";
        public void StatsInfo() {

            Console.WriteLine(StatsText);
            string choice = Console.ReadLine();

            if (choice != "1")
            {
                Console.Clear();
                StatsInfo();
            }
            else
            {
                Console.Clear();
                new MainMenu().RunMenu();
            }
        }
        
    }
}
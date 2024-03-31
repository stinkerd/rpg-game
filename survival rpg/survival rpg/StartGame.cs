using System.Data;
using System.IO;

namespace survival_rpg
{
    class StartGame
    {
    public void RunStartGame()
    {
            // Check for save file. if it does not exist, start new file.
            if (!File.Exists("..\\..\\..\\save.dat"))
            {
                Console.WriteLine("No save file found. Starting new game.\n");
                new CharacterSelection().ChooseCharacter();
            }
            else
            {
                Console.WriteLine("Save file found.");
                Console.WriteLine("1. Continue");
                Console.WriteLine("2. Delete Save");
                Console.WriteLine("3. New Game");
                Console.WriteLine("------------------");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Continue (Not Implemented Yet)
                    Console.Clear();
                    Console.WriteLine("Continue functionality not yet implemented.\n");
                    RunStartGame(); // Restart menu for now
                    return;
                }
                else if (choice == 2)
                {
                    bool ConfirmDelete()
                    {
                        Console.Clear();
                        Console.WriteLine("Are you sure you want to delete your save file?\nThis cannot be undone. (y/n)");
                        Console.WriteLine("------------------");
                        string confirm = Console.ReadLine().ToLower();

                        if (confirm == "y")
                        {
                            File.Delete("..\\..\\..\\save.dat");
                            return true;
                        }
                        else if (confirm == "n")
                        {
                            Console.Clear();
                            RunStartGame();
                            return false;
                        }
                        else
                        {
                            return ConfirmDelete();
                        }
                    }
                    if (ConfirmDelete())
                    {
                        // Choose Character Class
                        Console.Clear();
                        new MainMenu().RunMenu();
                    }
                }
                else if (choice == 3)
                {
                    bool ConfirmRestart()
                    {
                        Console.Clear();
                        Console.WriteLine("Are you sure you would like to overwrite your previous save file?\nThis cannot be undone. (y/n)");
                        Console.WriteLine("------------------");
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
                            return ConfirmRestart();
                        }
                    }
                    if (ConfirmRestart())
                    {
                        // Choose Character Class
                        Console.Clear();
                        File.Delete("..\\..\\..\\save.dat");
                        new CharacterSelection().ChooseCharacter();
                    }
                }
                else
                {
                    RunStartGame();
                }
            }
    }
    }

}
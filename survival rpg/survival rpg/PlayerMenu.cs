using survival_rpg;
using System;
using System.Collections.Generic;

public class PlayerMenu
{
    public void ShowMenu()
    {

        Console.WriteLine("** Actions Menu **");
        Thread.Sleep(200);
        Console.WriteLine("1. Explore");
        Thread.Sleep(200);
        Console.WriteLine("2. Manage Inventory");
        Thread.Sleep(200);
        Console.WriteLine("3. Open Menu");
        Console.WriteLine("------------------");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Not implemented yet!\n");
                ShowMenu();
                // Explore logic (implement based on your game design)
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Not implemented yet!\n");
                ShowMenu();
                /*ManageInventory();*/
                break;
            case "3":
                Console.Clear();
                ShowOptionsMenu();
                break;
            default:
                Console.Clear();
                ShowMenu();
                break;
        }
    }

    private void ManageInventory()
    {
        Console.WriteLine("Inventory ({count} / {capacity})"); // Capacity to be implemented later

        // Display list of items or message if empty

/*        if (count == 0)
        {
            Console.WriteLine("Your inventory is empty.");
        }
        else
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. { inventory[i].ItemData.Name} (x{inventory[i].Quantity})");
            }
        }*/

        Console.WriteLine("\n(ESC) Go Back");
        Console.WriteLine("Type item number or name to inspect:");

        string input = Console.ReadLine();

        if (input == "\u001B") // Check for ESC key
        {
            return;
        }
/*        else if (input == i || input == inventory[i].ItemData.Name)
        {
            // Handle item inspection based on input (logic not implemented here)
        }*/
    }

    private void ShowOptionsMenu()
    {

        Random random = new Random();
        int randomNumber = random.Next(500, 5001);

        Console.WriteLine("** Options menu **");
        Thread.Sleep(200);
        Console.WriteLine("1. Show Stats");
        Thread.Sleep(200);
        Console.WriteLine("2. Recover Fatigue (Rest)");
        Thread.Sleep(200);
        Console.WriteLine("3. Exit Game Without Saving");
        Thread.Sleep(200);
        Console.WriteLine("4. Exit Game With Saving");
        Thread.Sleep(200);
        Console.WriteLine("5. Exit Menu");
        Console.WriteLine("------------------");

        string choice = Console.ReadLine();
        if (choice == "\u001B") // Check for ESC key
        {
            return;
        }
        switch (choice)
        {
            case "1":
                // Show player stats
                Console.Clear();
                Console.WriteLine("Not implemented yet!\n");
                ShowOptionsMenu();
                break;
            case "2":
                // Rest logic
                Console.Clear();
                Console.WriteLine("Not implemented yet!\n");
                ShowOptionsMenu();
                break;
            case "3":
                // Exit game logic
                Console.Clear();
                Console.WriteLine("Exiting without saving...");

                Thread.Sleep(randomNumber);
                new MainMenu().RunMenu();
                break;
            case "4":
                // Save game logic
                Console.WriteLine("Saving game...");

                Thread.Sleep(randomNumber);
                Console.Clear();
                new MainMenu().RunMenu();
                break;
            case "5":
                Console.Clear();
                ShowMenu();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

public class PlayerItem
{
    public Item ItemData { get; private set; }
    public int Quantity { get; set; }

    public PlayerItem(Item itemData, int quantity = 1)
    {
        ItemData = itemData;
        Quantity = quantity;
    }
}

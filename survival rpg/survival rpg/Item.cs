using System;
using survival_rpg;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool CanBeEquipped { get; set; }
    public bool CanBeConsumed { get; set; }
    public int Value { get; set; } // Placeholder for future use

    public Item(string name, string description, bool canBeEquipped, bool canBeConsumed, int value)
    {
        Name = name;
        Description = description;
        CanBeEquipped = canBeEquipped;
        CanBeConsumed = canBeConsumed;
        Value = value;
    }
}

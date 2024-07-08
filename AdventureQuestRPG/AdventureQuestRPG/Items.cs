using System;

namespace AdventureQuestRPG
{
    public abstract class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Sword : Items
    {
        public Sword()
        {
            Name = "Sword";
            Description = "Increases Attack Power by 5.";
        }
    }

    public class Armor : Items
    {
        public Armor()
        {
            Name = "Armor";
            Description = "Increases Defense by 5.";
        }
    }

    public class Vitality : Items
    {
        public Vitality()
        {
            Name = "Vitality";
            Description = "Increases Health by 5.";
        }
    }
}

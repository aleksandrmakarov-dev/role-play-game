using RolePlayGame.Core.Entities.Utils;

namespace RolePlayGame.Core.Inventory
{
    public abstract class Item
    {
        public double Weight { get; private set; }
        public string? Name { get; private set; }
        public double Price { get; private set; }
        public Rarity Rarity { get; private set; }

        public Item(double weight, string? name, double price, Rarity rarity) 
        {
            Weight = weight;
            if (name != null) 
            {
                Name = name;
            }else { name = "uncknown"; }
            Price = price;
            Rarity = rarity;
        }

    }
}

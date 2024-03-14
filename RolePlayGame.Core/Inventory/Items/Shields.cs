
using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inventory.Items.itemsUtils;

namespace RolePlayGame.Core.Inventory.Items
{
    public class Shields :Item
    {
        public int ArmorBonus { get; private set; }
        public List<ShieldsSpecial> Specials { get; private set; }
        public Shields(double weight, string? name, double price, Rarity rarity, List<ShieldsSpecial> specials, int armorBonus)
            : base(weight, name, price, rarity)
        {
            Specials = specials;
            ArmorBonus = armorBonus;    
        }
    }
}

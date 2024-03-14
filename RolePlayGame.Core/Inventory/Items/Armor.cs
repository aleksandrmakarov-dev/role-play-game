using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inventory.Items.itemsUtils;

namespace RolePlayGame.Core.Inventory.Items
{
    public class Armor: Item
    {
        public ArmorType Type { get; private set; }
        public int ArmorClass { get; private set; }
        public List<ArmorSpecial> Special { get; private set; }
        public Armor(double weight,
            ArmorType type,
            int armorClass,
            string? name,
            double price,
            Rarity rarity) :base(weight,name,price,rarity) { Type = type; ArmorClass = armorClass; }
    }
}

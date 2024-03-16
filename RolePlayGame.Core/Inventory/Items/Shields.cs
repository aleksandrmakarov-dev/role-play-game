
using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inv.Items.itemsUtils;

namespace RolePlayGame.Core.Inv.Items
{
    public class Shields : Item, IEquipable, IHandsEquipable
    {
        public int ArmorBonus { get; private set; }
        public List<ShieldsSpecial> Specials { get; private set; }
        public Shields(double weight, string? name, double price, Rarity rarity, List<ShieldsSpecial> specials, int armorBonus)
            : base(weight, name, price, rarity)
        {
            Specials = specials;
            ArmorBonus = armorBonus;
        }

        public double GetArmorBonus() { return ArmorBonus; }
       
    } 
}

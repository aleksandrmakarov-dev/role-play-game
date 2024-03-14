using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inventory.Items.itemsUtils;

namespace RolePlayGame.Core.Inventory.Items
{
    public class Clothes :Item
    {
        public List<ClothesSpecial> Specials { get;private set; }
        public Clothes(double weight, string? name, double price, Rarity rarity, List<ClothesSpecial> specials) 
            :base(weight,name,price,rarity) 
        {
            Specials = specials;
        }
    }
}

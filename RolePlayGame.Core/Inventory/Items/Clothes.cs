using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inv.Items.itemsUtils;

namespace RolePlayGame.Core.Inv.Items
{
    public class Clothes :Item, IEquipable
    {
        public List<ClothesSpecial> Specials { get;private set; }
        public Clothes(double weight, string? name, double price, Rarity rarity, List<ClothesSpecial> specials) 
            :base(weight,name,price,rarity) 
        {
            Specials = specials;
        }
    }
}

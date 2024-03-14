using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inventory.Items.itemsUtils;

namespace RolePlayGame.Core.Inventory.Items
{

   

    public class Weapon : Item
    {
        public double MinDamage { get; private set; }
        public double MaxDamage { get; private set; }
        public double Range { get; private set; }
        public List<WeaponType> WType { get; private set; }
        public List<DamageType> DType { get; private set; }
        public List<WeaponSpecial> Specials { get; private set; }


        public Weapon(double weight,
            string? name,
            double price,
            Rarity rarity,
            double minDamage,
            double maxDamage,
            double range,
            List<WeaponType> wType,
            List<DamageType> dType,
            List<WeaponSpecial> specials) : base(weight, name, price, rarity)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Range = range;
            DType = dType;
            WType = wType;
            Specials = specials;
        }
    }
}

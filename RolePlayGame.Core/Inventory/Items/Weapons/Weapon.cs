using RolePlayGame.Core.Entities.Utils;
using RolePlayGame.Core.Inv.Items.itemsUtils;

namespace RolePlayGame.Core.Inv.Items.Weapons
{



    public class Weapon<T> : Item, IEquipable, IHandsEquipable where T : WeaponType
    {
        public double MinDamage { get; private set; }
        public double MaxDamage { get; private set; }
        public double Range { get; private set; }
        public WeaponType WType { get; private set; }
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
            Specials = specials;
        }

        public double GetArmorBonus() { return 0; }
    }
}
